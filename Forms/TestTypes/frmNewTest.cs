using LabLink.Helper;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabLink.Forms.TestTypes
{
    public partial class frmNewTest : MetroForm
    {
        public frmNewTest()
        {
            InitializeComponent();
            ButtonStyles.PrimaryButton(btnAddTestType);
            ButtonStyles.SecondaryButton(btnCancel);
        }
    }
}
