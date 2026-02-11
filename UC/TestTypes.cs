using LabLink.Helper;
using LabLink.Models;
using LabLink.Services;
using Syncfusion.Windows.Forms.Enums;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
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
    public partial class TestTypes : UserControl, IAsyncLoadable
    {
        private ObservableCollection<TestTypeModel> testTypeCollection;
        public TestTypes()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ButtonStyles.PrimaryButton(btnAddTestType);
            ButtonStyles.SecondaryButton(btnRefresh);

            dgvTestTypes.AutoGenerateColumns = false;

            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "TestTypeName", HeaderText = "TEST TYPE" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "CategoryName", HeaderText = "CATEGORY" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "TurnAroundTime", HeaderText = "TURNAROUND (HRS)", Format = "{0}h" });
            dgvTestTypes.Columns.Add(new GridTextColumn { MappingName = "IsActive", Width = 150, HeaderText = "STATUS" });
        }

        public async Task LoadDataAsync()
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
            await LoadDataAsync();
        }

        private void dgvTestTypes_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "IsActive")
            {
                if (e.DisplayText == "True")
                {
                    e.Style.TextColor = Color.Green;
                    e.DisplayText = "Active";
                    e.Style.Font.Bold = true;
                }
                else if (e.DisplayText == "False")
                {
                    e.Style.TextColor = Color.Red;
                    e.DisplayText = "Inactive";
                    e.Style.Font.Bold = true;
                }
            }

            if (e.Column.MappingName == "TestTypeName")
            {
                e.Style.Font.Bold = true;
            }
        }
    }
}
