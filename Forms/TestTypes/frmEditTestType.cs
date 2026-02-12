using LabLink.Models;
using LabLink.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabLink.Forms.TestTypes
{
    public partial class frmEditTestType : MetroForm
    {
        private ObservableCollection<TestTypeModel> _testTypes;
        private int _testTypeID;
        public frmEditTestType(ObservableCollection<TestTypeModel> testTypes, int testTypeID)
        {
            InitializeComponent();
            Helper.ButtonStyles.PrimaryButton(btnSaveChanges);
            Helper.ButtonStyles.SecondaryButton(btnCancel);

            _testTypes = testTypes;
            _testTypeID = testTypeID;
        }

        private void LoadCategory()
        {
            try
            {
                DataTable categories = TestTypeService.GetCategory();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private async Task LoadTestTypeDetails()
        {
            TestTypeModel? testType = await TestTypeService.GetTestTypeID(_testTypeID);

            if (testType != null)
            {
                _testTypeID = testType.TestTypeID;
                txtTestTypeName.Text = testType.TestTypeName;
                cmbCategory.SelectedValue = testType.CategoryID;
                txtTurnaroundTime.Value = testType.TurnAroundTime;
                cbIsActive.Checked = testType.IsActive;
            }
        }

        private async void frmEditTestType_Load(object sender, EventArgs e)
        {
            LoadCategory();
            await LoadTestTypeDetails();
        }
    }
}
