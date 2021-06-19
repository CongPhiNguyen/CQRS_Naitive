using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediaShareApp.SQLHandler.SQL_Write
{
	class SQL_Write
	{
        public void insertPic(String HoTen ,byte[] img)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "nguyencongphi.database.windows.net";
                builder.UserID = "nguyencongphi";
                builder.Password = "kratos123@";
                builder.InitialCatalog = "writeModel";

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
                string query = "insert into VIDEO(IMG, Ten) values (@img, @HoTen)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                cmd.Parameters.Add(new SqlParameter("@HoTen", HoTen));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
