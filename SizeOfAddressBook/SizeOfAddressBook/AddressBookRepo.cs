using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SizeOfAddressBook
{
    class AddressBookRepo
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionString);
        public bool AddContact(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    //var qury=values()
                    SqlCommand command = new SqlCommand("SpAddContacts", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.address);
                    command.Parameters.AddWithValue("@City", model.city);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", model.Email);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
        public bool EditContact(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    model.FirstName = "Darshan";
                    //var qury=values()
                    SqlCommand command = new SqlCommand("SpEditContact", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.address);
                    command.Parameters.AddWithValue("@City", model.city);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", model.Email);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
        public bool DeleteContact(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    model.FirstName = "Darshan";
                    //var qury=values()
                    SqlCommand command = new SqlCommand("SpDeleteContact", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.address);
                    command.Parameters.AddWithValue("@City", model.city);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", model.Email);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
        public bool GetAllContact()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                // SqlConnection connection = new SqlConnection(connectionString);
                AddressBookModel addressBookmodel = new AddressBookModel();
                using (connection)
                {
                    string query = @"Select * from AddressBookTable";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            addressBookmodel.FirstName = dr.GetString(1);
                            addressBookmodel.LastName = dr.GetString(2);
                            addressBookmodel.address = dr.GetString(3);
                            addressBookmodel.city = dr.GetString(4);
                            addressBookmodel.State = dr.GetString(5);
                            addressBookmodel.Zip = dr.GetString(6);
                            addressBookmodel.PhoneNumber = dr.GetString(7);
                            addressBookmodel.Email = dr.GetString(8);
                            // addressBookmodel.Id = dr.GetInt32(8);
                            Console.WriteLine(addressBookmodel.FirstName + " " + addressBookmodel.LastName + " " + " " + addressBookmodel.address + " " + addressBookmodel.city + " " + addressBookmodel.State + " " + addressBookmodel.PhoneNumber + " " + addressBookmodel.Zip + " " + addressBookmodel.Email);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool SizeOfAddressBook()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);                
                AddressBookModel addressBookmodel = new AddressBookModel();
                using (connection)
                {
                    string query = @"Select COUNT (*) State From AddressBookTable";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    Int32 count = (Int32)cmd.ExecuteScalar();
                    Console.WriteLine(count);
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
