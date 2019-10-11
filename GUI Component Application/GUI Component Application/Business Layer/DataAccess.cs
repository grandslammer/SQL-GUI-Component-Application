using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Component_Application.Business_Layer
{
    class DataAccess
    {

        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ComponentDB.mdf;Integrated Security = True; Connect Timeout = 30";
        public static DataTable GetComponents()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    // 1. Create a command object identifying the stored procedure
                    SqlCommand command = new SqlCommand("sp_GetComponents", dbConnection);

                    // 2. Set the command object so it knows to execute a stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // 3. Load Table
                    table.Load(command.ExecuteReader());

                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return table;
        }
            
        public static bool DeleteComponent(int c_SKU)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    // 1. Create a command object identifying the stored procedure
                    SqlCommand command = new SqlCommand("sp_DeleteComponent", dbConnection);

                    // 2. Set the command object so it knows to execute a stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // 3. Execute store procedure
                    command.Parameters.Add(new SqlParameter("@SKU", c_SKU));

                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AddComponent(string name, string desc, double price, string cat, string subcat, byte[] image, DateTime date, bool available)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    // 1. Create a command object identifying the stored procedure
                    SqlCommand command = new SqlCommand("sp_AddComponent", dbConnection);

                    // 2. Set the command object so it knows to execute a stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // 3. Execute store procedure
                    command.Parameters.Add(new SqlParameter("@Name", name));
                    command.Parameters.Add(new SqlParameter("@Description", desc));
                    command.Parameters.Add(new SqlParameter("@Price", price));
                    command.Parameters.Add(new SqlParameter("@Category", cat));
                    command.Parameters.Add(new SqlParameter("@SubCategory", subcat));
                    command.Parameters.Add(new SqlParameter("@DateFirstInStock", date));
                    command.Parameters.Add(new SqlParameter("@Com_Image", image));
                    command.Parameters.Add(new SqlParameter("@Available", available));

                    command.ExecuteNonQuery();
                    command.Dispose();

                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static DataTable GetUsers()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    // 1. Create a command object identifying the stored procedure
                    SqlCommand command = new SqlCommand("sp_GetUsers", dbConnection);

                    // 2. Set the command object so it knows to execute a stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // 3. Load Table
                    table.Load(command.ExecuteReader());

                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return table;
        }

        public static DataTable SearchAllComponents(string sqlString)
        {
            DataTable ComponentTable = new DataTable();
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    //1. create a command object identifying the stored procedure
                    SqlCommand command = new SqlCommand(sqlString, dbConnection);

                    //2. set the command object so it knows to execute a stored procedure command
                    // command.CommandType = CommandType.Text;

                    //3. LOAD TABLE
                    ComponentTable.Load(command.ExecuteReader());

                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ComponentTable;
        }

        public static bool EditComponent(int sku, string name, string desc, double price, string cat, string subcat, byte[] image, DateTime date, bool available)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    // 1. Create a command object identifying the stored procedure
                    SqlCommand command = new SqlCommand("sp_EditComponent", dbConnection);

                    // 2. Set the command object so it knows to execute a stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // 3. Execute store procedure
                    command.Parameters.Add(new SqlParameter("@SKU", sku));
                    command.Parameters.Add(new SqlParameter("@Name", name));
                    command.Parameters.Add(new SqlParameter("@Description", desc));
                    command.Parameters.Add(new SqlParameter("@Price", price));
                    command.Parameters.Add(new SqlParameter("@Category", cat));
                    command.Parameters.Add(new SqlParameter("@SubCategory", subcat));
                    command.Parameters.Add(new SqlParameter("@Image", image));
                    command.Parameters.Add(new SqlParameter("@DateTime", date));
                    command.Parameters.Add(new SqlParameter("@Available", available));

                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
