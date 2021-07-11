using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RealEstate
{
    class RestateRepository : IRealEstateRepository
    {
        //private string connectionstring = @"data source=mardi\sql2019;initial catalog=realstate_db;user id=sa;password=9869;integrated security=true; ";
        private string connectionString = @"Data Source=.;Initial Catalog=RealState_DB;Integrated Security=True; ";
        public bool deleteItem(int itemId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From EstateTable where ItemID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", itemId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }

        public bool insertItem(string itemName, int squareMeters, string itemOptions, string sellerName, string sellerMobile, int itemPrice)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into EstateTable (ItemName,SquareMeters,Options,SellerName,SellerMobile,Price) values (@ItemName,@SquareMeters,@Options,@SellerName,@SellerMobile,@Price)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@SquareMeters", squareMeters);
                command.Parameters.AddWithValue("@Options", itemOptions);
                command.Parameters.AddWithValue("@SellerName", sellerName);
                command.Parameters.AddWithValue("@SellerMobile", sellerMobile);
                command.Parameters.AddWithValue("@Price", itemPrice);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Search(string parameter)
        {
            string query = "Select * From EstateTable where ItemName like @parameter or SellerName like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SelectAll()
        {
            string query = "Select * From EstateTable";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dato = new DataTable();
            adapter.Fill(dato);
            return dato;

        }

        public DataTable SelectRow(int itemId)
        {
            string query = "Select * From EstateTable where ItemID = " + itemId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool updateItem(int itemId, string itemName, int squareMeters, string itemOptions, string sellerName, string sellerMobile, int itemPrice)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update EstateTable Set ItemName=@ItemName,SquareMeters=@SquareMeters,Options=@Options,SellerName=@SellerName,SellerMobile=@SellerMobile,Price=@Price Where ItemID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", itemId);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@SquareMeters", squareMeters);
                command.Parameters.AddWithValue("@Options", itemOptions);
                command.Parameters.AddWithValue("@SellerName", sellerName);
                command.Parameters.AddWithValue("@SellerMobile", sellerMobile);
                command.Parameters.AddWithValue("@Price", itemPrice);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
