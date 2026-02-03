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
    public partial class TestTypes : UserControl
    {
        public TestTypes()
        {
            InitializeComponent();
            ButtonStyles.PrimaryButton(btnAddTestType);
            ButtonStyles.SecondaryButton(btnRefresh);
        }
    }
}
