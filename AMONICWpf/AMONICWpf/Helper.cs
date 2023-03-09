using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Configuration;
using System.Text;

namespace AMONICWpf
{

    
    internal class Helper
    {
        private static string connectionString = "Data Source=KEKS\\SQLEXPRESS;Initial Catalog=Session1_XX;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
       
        public void create()
        {
            
            
        }





        public static bool login(string email, string pass)
        {
            connection.Open();
            SqlCommand logCommand = new SqlCommand("Select * from users where Email='"+ email+"' and Password='"+ returnHashPass(pass)+"';", connection);
            SqlDataReader reader = logCommand.ExecuteReader();
            bool result = reader.HasRows;
            connection.Close();
            return result;
        }








        public static string returnHashPass(string pass)
        { 
            MD5 md5 = MD5.Create();
            var hash = Encoding.UTF8.GetBytes(pass);

            return Convert.ToBase64String(md5.ComputeHash(hash));
        }

    }
}
