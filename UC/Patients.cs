using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLink.UC
{
    public partial class Patients : UserControl
    {
        private ObservableCollection<PatientsModel> patientsCollection;
        public Patients()
        {
            InitializeComponent();
            ButtonStyles.PrimaryButton(btnAddPatient);
            ButtonStyles.SecondaryButton(btnRefresh);
            ButtonStyles.PrimaryButton(btnNewTest);
            ButtonStyles.TernaryButton(btnCancel);
        }

        private async void btnAddPatient_Click(object sender, EventArgs e)
        {
            new Forms.Patients.frmNewPatient(patientsCollection).ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    dgvPatients.DataSource = await Services.PatientService.GetPatients();
            //}
        }

        private async Task LoadData()
        {
            //dgvPatients.DataSource = await Services.PatientService.GetPatients();
            //dgvPatients.Columns["PatientID"].Visible = false;
            ////dgvPatients.RowHeadersVisible = false;
            ////dgvPatients.ColumnHeadersVisible = false;
            ///

            try
            {
                patientsCollection = await PatientService.GetPatients();
                dgvPatients.DataSource = patientsCollection;

                dgvPatients.Columns["PatientID"].Visible = false;
                dgvPatients.Columns["ConsentToSMS"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Patients_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
            ClearFields();
        }

        private async Task PopulatePatientInfo(int patientId)
        {
            try
            {
                PatientsModel? patient = await PatientService.GetPatientById(patientId);

                if (patient != null)
                {
                    txtPhoneNumber.ReadOnly = true;
                    txtFullname.ReadOnly = true;
                    cbConsentSMS.Enabled = false;

                    txtFullname.Text = patient.FullName;
                    txtPhoneNumber.Text = patient.PhoneNumber;
                    cbConsentSMS.Checked = patient.ConsentToSMS;

                }
                else
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving patient details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullname.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                if (btnEdit.Text == "Edit")
                {
                    btnEdit.Text = "Save";
                    ButtonStyles.PrimaryButton(btnEdit);
                    txtFullname.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    cbConsentSMS.Enabled = true;
                }
                else if (btnEdit.Text == "Save")
                {
                    try
                    {
                        if (dgvPatients.SelectedItem is PatientsModel selectedPatient)
                        {
                            selectedPatient.FullName = txtFullname.Text;
                            selectedPatient.PhoneNumber = txtPhoneNumber.Text;
                            selectedPatient.ConsentToSMS = cbConsentSMS.Checked;

                            PatientService.UpdatePatient(selectedPatient);

                            MessageBox.Show("Patient details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating patient details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFields()
        {
            txtFullname.Clear();
            txtPhoneNumber.Clear();
            cbConsentSMS.Checked = false;
            txtFullname.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            cbConsentSMS.Enabled = false;
            btnEdit.Text = "Edit";
            ButtonStyles.SecondaryButton(btnEdit);
        }

        private async void dgvPatients_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index >= 0)
            {
                if (e.DataRow.RowData is PatientsModel patient)
                {
                    int patientId = patient.PatientID;
                    await PopulatePatientInfo(patientId);
                    MessageBox.Show(patientId.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
