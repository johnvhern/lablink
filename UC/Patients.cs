using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using System;
using System.Collections.Generic;
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
        public Patients()
        {
            InitializeComponent();
            ButtonStyles.PrimaryButton(btnAddPatient);
            ButtonStyles.PrimaryButton(btnSaveChanges);
            ButtonStyles.SecondaryButton(btnRefresh);
            ButtonStyles.SecondaryButton(btnNewTest);
            ButtonStyles.TernaryButton(btnCancel);
        }

        private async void btnAddPatient_Click(object sender, EventArgs e)
        {
            DialogResult result = new Forms.Patients.frmNewPatient().ShowDialog();

            if (result == DialogResult.OK)
            {
                dgvPatients.DataSource = await Services.PatientService.GetPatients();
            }
        }

        private async void LoadData()
        {
            dgvPatients.DataSource = await Services.PatientService.GetPatients();
            dgvPatients.Columns["PatientID"].Visible = false;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.ColumnHeadersVisible = false;
        }

        private async void Patients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPatients.DataSource = await PatientService.GetPatients();
            ClearFields();
        }

        private async void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int patientId = Convert.ToInt32(dgvPatients.Rows[e.RowIndex].Cells["PatientID"].Value);
                await PopulatePatientInfo(patientId);
            }
        }

        private async Task PopulatePatientInfo(int patientId)
        {
            try
            {
                PatientsModel patient = await PatientService.GetPatientById(patientId);

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
                txtFullname.ReadOnly = false;
                txtPhoneNumber.ReadOnly = false;
                cbConsentSMS.Enabled = true;
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
        }
    }
}
