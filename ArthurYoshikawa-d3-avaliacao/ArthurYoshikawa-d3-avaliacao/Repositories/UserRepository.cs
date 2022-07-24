using ArthurYoshikawa_d3_avaliacao.Model;
using System;using System.Collections.Generic;
using System.Data.SqlClient;

namespace ArthurYoshikawa_d3_avaliacao.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString =
            @"Data Source=LAPTOP-DKLD9FBM\SQLEXPRESS;Initial Catalog=Registry;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;";

        public User GetByEmail(string email)
        {
            User selectedUser = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string querySelect = $"SELECT UserId, Name, Email, Password FROM Users WHERE Email = @Email";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        User user = new()
                        {
                            Id = rdr[0].ToString(),

                            Name = rdr["Name"].ToString(),

                            Email = rdr["Email"].ToString(),

                            Password = rdr["Password"].ToString()
                        };

                        selectedUser = user;
                    }
                    return selectedUser;
                }
            }
        }
    }
}