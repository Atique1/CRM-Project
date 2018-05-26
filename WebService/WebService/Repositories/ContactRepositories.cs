using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.Repositories
{
    public class ContactRepositories
    {
        public static bool AddContactToDB(Contact contact)
        {
            var connectionString = "Data Source=.;Initial Catalog=ContactManager;User Id = sa; Password=12345";
            var query = "INSERT INTO Contact(Name, PhoneNumber, Note) VALUES ('@Name','@PhoneNum','@Note');";

            query = query.Replace("@Name", contact.Name).Replace("@PhoneNum", contact.PhoneNumber).Replace("@Note", contact.Note);

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                return true;
            }

            catch(Exception)
            {
                return false;
            }

        }
    }
}