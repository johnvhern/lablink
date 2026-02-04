using LabLink.Data;
using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using LabLink.UC;
using Microsoft.Data.SqlClient;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabLink.Forms.Patients
{
    public partial class frmNewPatient : MetroForm
    {
        private ObservableCollection<PatientsModel> _patientsCollection;
        public frmNewPatient(ObservableCollection<PatientsModel> patientCollection)
        {
            InitializeComponent();

            _patientsCollection = patientCollection;

            ButtonStyles.PrimaryButton(btnAddPatient);
            ButtonStyles.SecondaryButton(btnCancel);

            txtFullName.TextChanged += details_TextChanged;
            txtPhoneNumber.TextChanged += details_TextChanged;
        }

        public static bool IsValidPHNumber(string phoneNumber)
        {
            // Pattern: +63 or 0 followed by 9, then 9 digits
            string pattern = @"^(\+63|0)9\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                var patient = new PatientsModel
                {
                    FullName = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    ConsentToSMS = cbConsentToSMS.Checked,
                };

                var context = new ValidationContext(patient, null, null);
                var validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(patient, context, validationResults, true);

                if (!isValid)
                {
                    // Collect all error messages
                    var errorMessages = validationResults.Select(vr => vr.ErrorMessage);

                    // Combine with line breaks
                    string allErrors = string.Join(Environment.NewLine, validationResults.Select((vr, index) => $"{index + 1}. {vr.ErrorMessage}"));

                    // Show in one MessageBox
                    MessageBox.Show(allErrors, "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int newID = PatientService.AddPatient(patient);
                        patient.PatientID = newID;
                        _patientsCollection.Add(patient);
                        MessageBox.Show("Patient added successfully");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to add patient");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void details_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                btnAddPatient.Enabled = true;

            }
            else
            {
                btnAddPatient.Enabled = false;
            }
        }
    }
}
