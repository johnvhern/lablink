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
        public async static Task<TestTypeModel?> GetTestTypeID(int patientID)
        {
            string query = "SELECT TestID, TestTypeName, Category, TurnAroundTime, IsActive FROM TestTypes WHERE TestID = @TestTypeID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TestTypeID", patientID);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return new TestTypeModel
                                {
                                    TestTypeID = reader.GetInt32(reader.GetOrdinal("TestID")),
                                    TestTypeName = reader.GetString(reader.GetOrdinal("TestTypeName")),
                                    CategoryID = reader.GetInt32(reader.GetOrdinal("Category")),
                                    TurnAroundTime = reader.GetInt32(reader.GetOrdinal("TurnAroundTime")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
                                };
                            }
                            return null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading test type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async static Task<ObservableCollection<TestTypeModel>> GetTestTypesPaged(int pageNumber, int pageSize, string searchTerm)
        {
            string query = @"SELECT TestID, TestTypeName, Category, CategoryName, TurnAroundTime, IsActive FROM TestTypes INNER JOIN TestCategory ON TestTypes.Category = TestCategory.CategoryID WHERE (@Search = '' OR TestTypeName LIKE @SearchPattern OR CategoryName LIKE @SearchPattern) ORDER BY TestTypeName OFFSET @Offset ROWS FETCH NEXT @Limit ROWS ONLY";

            var testTypes = new ObservableCollection<TestTypeModel>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", searchTerm);
                        cmd.Parameters.AddWithValue("@SearchPattern", $"%{searchTerm}%");
                        cmd.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                        cmd.Parameters.AddWithValue("@Limit", pageSize);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                testTypes.Add(new TestTypeModel
                                {
                                    TestTypeID = reader.GetInt32(reader.GetOrdinal("TestID")),
                                    TestTypeName = reader.GetString(reader.GetOrdinal("TestTypeName")),
                                    CategoryID = reader.GetInt32(reader.GetOrdinal("Category")),
                                    CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                    TurnAroundTime = reader.GetInt32(reader.GetOrdinal("TurnAroundTime")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
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

        public async static Task<int> GetTotalTestTypes(string searchTerm = "")
        {
            string query = "SELECT COUNT(*) FROM TestTypes INNER JOIN TestCategory ON TestTypes.Category = TestCategory.CategoryID WHERE (@Search = '' OR TestTypes.TestTypeName LIKE @SearchPattern OR TestCategory.CategoryName LIKE @SearchPattern)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    await conn.OpenAsync();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", searchTerm);
                        cmd.Parameters.AddWithValue("@SearchPattern", $"%{searchTerm}%");
                        return (int)await cmd.ExecuteScalarAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
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
                    cmd.Parameters.AddWithValue("@IsActive", testType.IsActive);

                    return (int)cmd.ExecuteNonQuery();
                }
            }
        }

        public static int UpdateTestType(TestTypeModel testType)
        {
            string query = "UPDATE TestTypes SET TestTypeName = @TestTypeName, Category = @Category, TurnAroundTime = @TurnAroundTime, IsActive = @IsActive WHERE TestID = @TestTypeID";
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestTypeID", testType.TestTypeID);
                    cmd.Parameters.AddWithValue("@TestTypeName", testType.TestTypeName);
                    cmd.Parameters.AddWithValue("@Category", testType.CategoryID);
                    cmd.Parameters.AddWithValue("@TurnAroundTime", testType.TurnAroundTime);
                    cmd.Parameters.AddWithValue("@IsActive", testType.IsActive);
                    return (int)cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
