using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabLink.UC
{
    public partial class TestTypes : UserControl
    {
        private ObservableCollection<TestTypeModel> testTypeCollection;
        public TestTypes()
        {
            InitializeComponent();
            ButtonStyles.PrimaryButton(btnAddTestType);
            ButtonStyles.SecondaryButton(btnRefresh);

            dgvTestTypes.AutoGenerateColumns = false;

            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "TestTypeName" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "CategoryName" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "TurnAroundTime" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "IsActive", Width = 100});
        }

        private async Task LoadData()
        {
            try
            {
                dgvTestTypes.Columns["TestTypeName"].HeaderText = "TEST TYPE";
                dgvTestTypes.Columns["CategoryName"].HeaderText = "CATEGORY";
                dgvTestTypes.Columns["TurnAroundTime"].HeaderText = "TURNAROUND (HRS)";
                dgvTestTypes.Columns["IsActive"].HeaderText = "STATUS";

                testTypeCollection = await TestTypeService.GetTestTypes();
                dgvTestTypes.DataSource = testTypeCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading test types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTestType_Click(object sender, EventArgs e)
        {
            new Forms.TestTypes.frmNewTest(testTypeCollection).ShowDialog();
        }

        private async void TestTypes_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
