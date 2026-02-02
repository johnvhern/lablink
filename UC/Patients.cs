using LabLink.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            DialogResult result = new Forms.Patients.frmNewPatient().ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }
    }
}
