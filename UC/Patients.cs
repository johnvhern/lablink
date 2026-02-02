using LabLink.Helper;
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
    }
}
