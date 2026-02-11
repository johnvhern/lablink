using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
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
    public partial class Patients : UserControl, IAsyncLoadable
    {
        private ObservableCollection<PatientsModel> patientsCollection;
        private string searchText = string.Empty;
        private int currentPage = 1;
        private int pageSize = 100;
        private int totalRecords = 0;
        public Patients()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ButtonStyles.PrimaryButton(btnAddPatient);
            ButtonStyles.SecondaryButton(btnRefresh);
            ButtonStyles.SecondaryButton(btnFirstPage);
            ButtonStyles.SecondaryButton(btnPrevPage);
            ButtonStyles.SecondaryButton(btnNextPage);
            ButtonStyles.SecondaryButton(btnLastPage);
            ButtonStyles.PrimaryButton(btnNewTest);
            ButtonStyles.TernaryButton(btnCancel);

            dgvPatients.AutoGenerateColumns = false;

            dgvPatients.Columns.Add(new GridTextColumn { MappingName = "PatientID" });
            dgvPatients.Columns.Add(new GridTextColumn { MappingName = "FullName", Width = 300 });
            dgvPatients.Columns.Add(new GridTextColumn { MappingName = "PhoneNumber", Width = 240 });

            dgvPatients.Columns.Add(new GridImageColumn
            {
                MappingName = "ConsentToSMS",
                Width = 60,
                ImageLayout = ImageLayout.None,
                TextImageRelation = TextImageRelation.Overlay,
            });
        }

        private async void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (var frm = new Forms.Patients.frmNewPatient(patientsCollection))
            {
                frm.ShowDialog();
            }

            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                dgvPatients.ShowBusyIndicator = true;

                string searchTerm = txtSearchBox.Text.Trim();

                totalRecords = await PatientService.GetTotalPatientCount(searchTerm);
                patientsCollection = await PatientService.GetPatientsPaged(currentPage, pageSize, searchTerm);
                dgvPatients.DataSource = patientsCollection;

                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                int startRecord = totalRecords == 0 ? 0 : (currentPage - 1) * pageSize + 1;
                int endRecord = Math.Min(currentPage * pageSize, totalRecords);
                lblPage.Text = $"Page {currentPage} ({startRecord}-{endRecord} of {totalRecords})";

                if (currentPage > totalPages && totalPages > 0)
                {
                    currentPage = totalPages;
                    patientsCollection = await PatientService.GetPatientsPaged(currentPage, pageSize, searchTerm);
                    dgvPatients.DataSource = patientsCollection;
                }

                btnNextPage.Enabled = currentPage < totalPages;
                btnLastPage.Enabled = currentPage < totalPages;
                btnPrevPage.Enabled = currentPage > 1;
                btnFirstPage.Enabled = currentPage > 1;

                dgvPatients.Columns["PatientID"].Visible = false;
                dgvPatients.Columns["FullName"].CellStyle.Font.Bold = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvPatients.ShowBusyIndicator = false;
            }
        }

        private async void Patients_Load(object sender, EventArgs e)
        {
            currentPage = 1;
            await LoadDataAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
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

        private async void dgvPatients_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index >= 0)
            {
                if (e.DataRow.RowData is PatientsModel patient)
                {
                    int patientId = patient.PatientID;
                    await PopulatePatientInfo(patientId);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private async void searchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            currentPage = 1;
            await LoadDataAsync();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void dgvPatients_QueryImageCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryImageCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "ConsentToSMS" && e.Record is PatientsModel patient)
            {
                e.DisplayText = string.Empty;
                if (patient.ConsentToSMS)
                {
                    e.Image = Properties.Resources.checkbox_checked; // Replace with your actual image resource
                }
                else
                {
                    e.Image = Properties.Resources.checkbox_unchecked; // Replace with your actual image resource
                }
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadDataAsync();
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadDataAsync();
            }
        }

        private async void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling((double)totalRecords / pageSize);
            await LoadDataAsync();
        }

        private async void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            await LoadDataAsync();
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
    }
}
