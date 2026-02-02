using LabLink.Data;
using LabLink.Models;
using LabLink.UC;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
namespace LabLink.Services
{
    public static class PatientService
    {
        public static bool AddPatient(string fullName, string phoneNumber, bool consentToSMS)
        {
            string query = "INSERT INTO Patients (FullName, PhoneNumber, ConsentToSMS) " +
                           "VALUES (@FullName, @PhoneNumber, @ConsentToSMS)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@ConsentToSMS", consentToSMS);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async static Task<DataTable> GetPatients()
        {
            string query = "SELECT PatientID, FullName, PhoneNumber FROM Patients";

            var dataTable = new DataTable();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
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
