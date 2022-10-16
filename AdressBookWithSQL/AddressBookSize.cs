using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookWithSQL
{
    public class AddressBookSize
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService1;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void SizeOfAddressBookByCity()
        {

            try
            {
                ContactModel model = new ContactModel();

                using (connection)
                {
                    string query = "SELECT City, COUNT(City) as Size FROM Address_Book Group by City";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.City = Convert.ToString(reader["City"]);
                            int size = Convert.ToInt32(reader["Size"]);

                            Console.WriteLine("{0}  {1}", model.City, size);
                        }
                    }
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
        public void SizeOfAddressBookByState()
        {

            try
            {
                ContactModel model = new ContactModel();

                using (connection)
                {
                    string query = "SELECT State, COUNT(State) as Size FROM Address_Book Group by State";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.State = Convert.ToString(reader["State"]);
                            int size = Convert.ToInt32(reader["Size"]);

                            Console.WriteLine("{0}  {1}", model.State, size);
                        }
                    }
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
