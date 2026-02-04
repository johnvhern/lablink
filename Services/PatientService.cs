using LabLink.Data;
using LabLink.Models;
using LabLink.UC;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
namespace LabLink.Services
{
    public static class PatientService
    {
        public static int AddPatient(PatientsModel patients)
        {
            string query = "INSERT INTO Patients (FullName, PhoneNumber, ConsentToSMS) " +
                           "VALUES (@FullName, @PhoneNumber, @ConsentToSMS)";

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", patients.FullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", patients.PhoneNumber);
                    cmd.Parameters.AddWithValue("@ConsentToSMS", patients.ConsentToSMS);

                    return (int)cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePatient(PatientsModel patient)
        {
            string query = "UPDATE Patients SET FullName = @FullName, PhoneNumber = @PhoneNumber, ConsentToSMS = @ConsentToSMS WHERE PatientID = @PatientID";

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                    cmd.Parameters.AddWithValue("@FullName", patient.FullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@ConsentToSMS", patient.ConsentToSMS);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public async static Task<ObservableCollection<PatientsModel>> GetPatients()
        {
            string query = "SELECT PatientID, FullName, PhoneNumber, ConsentToSMS FROM Patients";
            var patients = new ObservableCollection<PatientsModel>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                patients.Add(new PatientsModel
                                {
                                    PatientID = reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    ConsentToSMS = reader.GetBoolean(reader.GetOrdinal("ConsentToSMS")),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return patients;
        }

        public async static Task<PatientsModel?> GetPatientById(int patientId)
        {
            string query = "SELECT PatientID, FullName, PhoneNumber, ConsentToSMS FROM Patients WHERE PatientID = @PatientID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return new PatientsModel
                                {
                                    PatientID = reader.GetInt32(reader.GetOrdinal("PatientID")),
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    ConsentToSMS = reader.GetBoolean(reader.GetOrdinal("ConsentToSMS"))
                                };
                            }

                            return null; // Patient not found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
