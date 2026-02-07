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

            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "TestTypeName", HeaderText = "TEST TYPE" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "CategoryName", HeaderText = "CATEGORY" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "TurnAroundTime", HeaderText = "TURNAROUND (HRS)" });
            dgvTestTypes.Columns.Add(new GridCheckBoxColumn { MappingName = "IsActive", Width = 150, HeaderText = "STATUS" });
        }

        private async Task LoadData()
        {
            try
            {
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
