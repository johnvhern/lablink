using LabLink.Models;
using LabLink.Services;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var testType = new TestTypeModel
                {
                    TestTypeName = txtTestTypeName.Text,
                    CategoryID = (int)cmbCategory.SelectedValue,
                    CategoryName = cmbCategory.Text,
                    TurnAroundTime = (int)txtTurnaroundTime.Value,
                    Remarks = txtRemarks.Text,
                    IsActive = cbIsActive.Checked
                };

                var context = new ValidationContext(testType, null, null);
                var validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(testType, context, validationResults, true);

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
                        _testTypeID = TestTypeService.UpdateTestType(testType);
                        MessageBox.Show("Test type updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the test type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the test type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
