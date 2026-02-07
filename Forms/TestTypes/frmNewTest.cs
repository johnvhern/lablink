using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using LabLink.UC;
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
    public partial class frmNewTest : MetroForm
    {
        private ObservableCollection<TestTypeModel> _testTypes;
        public frmNewTest(ObservableCollection<TestTypeModel> testTypes)
        {
            InitializeComponent();

            _testTypes = testTypes;

            ButtonStyles.PrimaryButton(btnAddTestType);
            ButtonStyles.SecondaryButton(btnCancel);

            txtTestTypeName.TextChanged += details_TextChanged;
        }

        private void LoadCategory()
        {
            try
            {
                DataTable categories = TestTypeService.GetCategory();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void details_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTestTypeName.Text))
            {
                btnAddTestType.Enabled = true;
            }
            else
            {
                btnAddTestType.Enabled = false;
            }
        }

        private void btnAddTestType_Click(object sender, EventArgs e)
        {
            try
            {
                var testType = new TestTypeModel
                {
                    TestTypeName = txtTestTypeName.Text,
                    CategoryID = (int)cmbCategory.SelectedValue,
                    CategoryName = cmbCategory.Text,
                    TurnAroundTime = (int)txtTurnaroundTime.Value,
                    isActive = cbIsActive.Checked
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
                        int newID = TestTypeService.AddTestType(testType);
                        testType.TestTypeID = newID;
                        _testTypes.Add(testType);
                        MessageBox.Show("Test type added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the test type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the test type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNewTest_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}
