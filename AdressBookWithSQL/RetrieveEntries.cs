using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookWithSQL
{
    public class RetrieveEntries
    {

        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService1;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void SortedEntries()
        {
            try
            {
                ContactModel model = new ContactModel();
                using (connection)
                {
                    string query = "SELECT * FROM Address_Book ORDER BY City, FirstName;";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.FirstName = Convert.ToString(reader["FirstName"]);
                            model.LastName = Convert.ToString(reader["LastName"]);
                            model.Address = Convert.ToString(reader["Address"]);
                            model.City = Convert.ToString(reader["City"]);
                            model.State = Convert.ToString(reader["State"]);
                            model.Zip = Convert.ToInt32(reader["Zip"]);
                            model.PhoneNumber = Convert.ToInt64(reader["PhoneNumber"]);
                            model.Email = Convert.ToString(reader["Email"]);

                            Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}", model.FirstName, model.LastName, model.Address, model.City, model.State, model.Zip, model.PhoneNumber, model.Email);
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
