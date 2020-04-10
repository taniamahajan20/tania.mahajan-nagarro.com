using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService
{
    public class UserContext
    {
        public string ConnectionString { get; set; }
        public UserContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public User GetUser(int id)
        {
            User user = new User();
            string query = "select * from user";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User()
                        {
                            userId = Convert.ToInt32(reader["user_id"]),
                            Age = Convert.ToInt32(reader["age"]),
                            Name = reader["name"].ToString(),
                            Email = reader["email"].ToString()
                        };
                    }
                }
            }
            return user;
        }
    }
}
