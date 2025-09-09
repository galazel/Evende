using Evende.Model;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evende.Repository
{
    internal class CustomerRepository
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=Evende;Integrated Security=True;";
        public void AddCustomer(CustomerModel customerModel)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customers VALUES(@FirstName,@LastName,@CustomerAddress,@ContactNumber,@PasswordHash,@Email)", conn);
                cmd.Parameters.AddWithValue("@FirstName", customerModel.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customerModel.LastName);
                cmd.Parameters.AddWithValue("@CustomerAddress", customerModel.CustomerAddress);
                cmd.Parameters.AddWithValue("@ContactNumber", customerModel.ContactNumber);
                cmd.Parameters.AddWithValue("@PasswordHash", customerModel.PasswordHash);
                cmd.Parameters.AddWithValue("@Email", customerModel.Email);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }
        }
    }
}
