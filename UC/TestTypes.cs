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
        private string searchText = string.Empty;
        private int currentPage = 1;
        private int pageSize = 100;
        private int totalRecords = 0;
        public TestTypes()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ButtonStyles.PrimaryButton(btnAddTestType);
            ButtonStyles.SecondaryButton(btnRefresh);
            ButtonStyles.SecondaryButton(btnFirstPage);
            ButtonStyles.SecondaryButton(btnPrevPage);
            ButtonStyles.SecondaryButton(btnNextPage);
            ButtonStyles.SecondaryButton(btnLastPage);

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
                dgvTestTypes.ShowBusyIndicator = true;

                string searchTerm = txtSearchBox.Text.Trim();

                totalRecords = await TestTypeService.GetTotalTestTypes(searchTerm);
                testTypeCollection = await TestTypeService.GetTestTypesPaged(currentPage, pageSize, searchTerm);
                dgvTestTypes.DataSource = testTypeCollection;

                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                int startRecord = totalRecords == 0 ? 0 : (currentPage - 1) * pageSize + 1;
                int endRecord = Math.Min(currentPage * pageSize, totalRecords);
                lblStatus.Text = $"Page {currentPage} ({startRecord}-{endRecord} of {totalRecords})";

                if (currentPage > totalPages && totalPages > 0)
                {
                    currentPage = totalPages;
                    testTypeCollection = await TestTypeService.GetTestTypesPaged(currentPage, pageSize, searchTerm);
                    dgvTestTypes.DataSource = testTypeCollection;
                }

                btnNextPage.Enabled = currentPage < totalPages;
                btnLastPage.Enabled = currentPage < totalPages;
                btnPrevPage.Enabled = currentPage > 1;
                btnFirstPage.Enabled = currentPage > 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading test types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvTestTypes.ShowBusyIndicator = false;
            }
        }

        private async void btnAddTestType_Click(object sender, EventArgs e)
        {
            using (var frm = new Forms.TestTypes.frmNewTest(testTypeCollection))
            {
                frm.ShowDialog(); 
            }

            await LoadDataAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void TestTypes_Load(object sender, EventArgs e)
        {
            currentPage = 1;
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

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private async void timerSearch_Tick(object sender, EventArgs e)
        {
            timerSearch.Stop();
            currentPage = 1;
            await LoadDataAsync();
        }

        private async void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            await LoadDataAsync();
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadDataAsync();
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadDataAsync();
        }

        private async void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling((double)totalRecords / pageSize);
            await LoadDataAsync();
        }
    }
}
