using ASPCoreFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreFirstApp.Services
{
    public class ProductsDAO : IProductsDataService
    {

        //Connection string
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<ProductModel> AllProducts()
        {
            //Assume nothing is found
            List<ProductModel> foundProducts = new List<ProductModel>();

            //Uses prepared statements for security. @username @password are defined below
            string sqlStatement = "SELECT * FROM dbo.Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel((int)reader[0], (string)reader[1], (decimal)reader[2], (string)reader[3]));
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            return foundProducts;
        }

        public bool Delete(ProductModel product)
        {
            //Default to false
            bool productDeleted = false;

            //Prepared statement
            string sqlStatement = "DELETE FROM dbo.Products WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //define values of placeholder
                command.Parameters.AddWithValue("@Id", product.Id);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if(result == 1)
                    {
                        productDeleted = true;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return productDeleted;
        }

        public ProductModel GetProductById(int id)
        {
            ProductModel foundProduct = null;

            //uses prepared statements for security.
            string sqlStatement = "SELECT * FROM dbo.Products WHERE Id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //define the values of the placeholder.
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        foundProduct = new ProductModel((int)reader[0], (string)reader[1], (decimal)reader[2], (string)reader[3]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                };
            }
            return foundProduct;
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            //Assume nothing is found
            List<ProductModel> foundProducts = new List<ProductModel>();

            //Uses prepared statements for security. @username @password are defined below
            string sqlStatement = "SELECT * FROM dbo.Products WHERE Name LIKE @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //define the values of the two placeholders in the sqlStatement string
                command.Parameters.AddWithValue("@Name", '%' + searchTerm + '%');
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel((int)reader[0], (string)reader[1], (decimal)reader[2], (string)reader[3]));
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            return foundProducts;
        }
        public int Update(ProductModel product)
        {
            //Returns -1 if the update fails
            int newIdNumber = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE dbo.Products SET Name = @Name, Price = @Price, Description = @Description WHERE id = @Id";

                SqlCommand mycommand = new SqlCommand(query, connection);
                mycommand.Parameters.AddWithValue("@Id", product.Id);
                mycommand.Parameters.AddWithValue("@Name", product.Name);
                mycommand.Parameters.AddWithValue("@Price", product.Price);
                mycommand.Parameters.AddWithValue("@Description", product.Description);

                try
                {
                    connection.Open();
                    newIdNumber = Convert.ToInt32(mycommand.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                };
                return newIdNumber;
            }
        }
    }
}
