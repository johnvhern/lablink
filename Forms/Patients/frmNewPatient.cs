using LabLink.Helper;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabLink.Forms.Patients
{
    public partial class frmNewPatient : MetroForm
    {
        public frmNewPatient()
        {
            InitializeComponent();
            ButtonStyles.PrimaryButton(btnAddPatient);
            ButtonStyles.SecondaryButton(btnCancel);
        }
    }
}
