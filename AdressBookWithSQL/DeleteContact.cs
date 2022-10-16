using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookWithSQL
{
    public class DeleteContact
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService1;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void DeleteContactDetails()
        {
            try
            {
                using (connection)
                {
                    string query = "DELETE Address_Book WHERE FirstName = 'Roshan'";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        Console.WriteLine("Deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Data not found");
                    }

                    connection.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
