using LabLink.Data;
using LabLink.Models;
using Microsoft.Data.SqlClient;
using Microsoft.DotNet.DesignTools.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace LabLink.Services
{
    public static class TestTypeService
    {
        public async static Task<ObservableCollection<TestTypeModel>> GetTestTypes()
        {
            string query = "SELECT TestID, TestTypeName, Category, TurnAroundTime, IsActive FROM TestTypes";
            var testTypes = new ObservableCollection<TestTypeModel>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                testTypes.Add(new TestTypeModel
                                {
                                    TestTypeID = reader.GetInt32(reader.GetOrdinal("TestID")),
                                    TestTypeName = reader.GetString(reader.GetOrdinal("TestTypeName")),
                                    TurnAroundTime = reader.GetInt32(reader.GetOrdinal("TurnAroundTime")),
                                    isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading test types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return testTypes;
        }

        public static DataTable GetCategory()
        {
            string query = "SELECT CategoryID, CategoryName FROM TestCategory";
            DataTable dt = new DataTable();

            using (var conn = DBConnection.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
            return dt;
        }

        public static int AddTestType(TestTypeModel testType)
        {
            string query = "INSERT INTO TestTypes (TestTypeName, Category, TurnAroundTime, IsActive) VALUES (@TestTypeName, @Category, @TurnAroundTime, @IsActive)";

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestTypeName", testType.TestTypeName);
                    cmd.Parameters.AddWithValue("@Category", testType.CategoryID);
                    cmd.Parameters.AddWithValue("@TurnAroundTime", testType.TurnAroundTime);
                    cmd.Parameters.AddWithValue("@IsActive", testType.isActive);

                    return (int)cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
