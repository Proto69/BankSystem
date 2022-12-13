using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BankSystem
{
    //Ready
    internal class MySqlDatabase
    {
        private static readonly string connectionString = "Server=localhost;Database=bank;Uid=root;Pwd=12345;";
        private static readonly MySqlConnection connection = new(connectionString);

        //Done
        public static void CreateUser(PersonModel person)
        {
            if (person.Username.Length <= 2)
                throw new Exception("The username is too short!");
            if (person.Username.Length >= 20)
                throw new Exception("The username is too long!");
            if (person.Password.Length < 8)
                throw new Exception("The password is too short!");
            BankManagment.user = person;
            connection.Open();

            MySqlCommand command = new MySqlCommand(@"
            INSERT INTO users (username, password) 
            VALUES (@value1, @value2)", connection);

            // Set the values for the parameters in the SQL query1
            command.Parameters.AddWithValue("@value1", person.Username);
            command.Parameters.AddWithValue("@value2", person.Password);

            // Execute the SQL query1
            command.ExecuteNonQuery();

            // Close the connection to the database
            connection.Close();
        }

        //Done
        internal static bool CheckUser(string username, string password)
        {
            //The query1
            string sql = $@"
            SELECT * FROM users WHERE username = @username;";
            
            //The command with values
            MySqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@username", username);

            //Starting the conn and executing the command
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            //Starts reading, if no result, skips
            while (reader.Read())
            {
                string password2 = reader["password"].ToString();
                double balance = double.Parse(reader["money"].ToString());
                string currency = reader["currency"].ToString();

                if (password == password2)
                {
                    connection.Close();
                    PersonModel person = new() { Username = username, Balance = balance, 
                        Password = password, Currency = currency, Logs = GetLogs(username) };
                    BankManagment.user = person;
                    
                    return true;
                }
                else
                    throw new Exception("Wrong password!");
            }

            connection.Close();
            return false;
        }

        //Done 
        internal static void DepositToBank(double money, string currencyOfMoney)
        {
            string username = BankManagment.user.Username;

            if (money <= 0)
                throw new Exception("Invalid amount of money!");

            string query1 = @"
            UPDATE users 
            SET money = @money, currency = @currency
            WHERE username = @username;
            ";

            string query2 = @"
            INSERT INTO logs (date, type, amount, username)
            VALUES (@date, @type, @amount, @username);
            ";

            MySqlCommand cmd1 = new(query1, connection);
            cmd1.Parameters.AddWithValue("@username", username);
            cmd1.Parameters.AddWithValue("@money", BankManagment.user.Balance + money);
            cmd1.Parameters.AddWithValue("@currency", currencyOfMoney);

            string date = DateTime.Now.ToString("HH:mm dd.MM.yyyy");

            MySqlCommand cmd2 = new(query2, connection);
            cmd2.Parameters.AddWithValue("@username", username);
            cmd2.Parameters.AddWithValue("@amount", money);
            cmd2.Parameters.AddWithValue("@date", date);
            cmd2.Parameters.AddWithValue("@type", "deposited");

            connection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            connection.Close();

            BankManagment.user.Balance += money;
            AddLog(date, "deposited", money);
        }

        //Done
        internal static string GetCountOfUsers()
        {
            string query = "SELECT COUNT(username) FROM users";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int count = reader.GetInt32(0);

            connection.Close();

            return count.ToString();
        }

        //Done 
        internal static void WithdrawFromBank(double amountOfMoney)
        {
            string username = BankManagment.user.Username;

            if (amountOfMoney <= 0 || amountOfMoney > BankManagment.user.Balance)
                throw new Exception("Invalid amount of money!");

            string query = @"
            UPDATE users 
            SET money = @money 
            WHERE username = @username
            ";

            string query2 = @"
            INSERT INTO logs (date, type, amount, username)
            VALUES (@date, @type, @amount, @username);
            ";

            MySqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@money", BankManagment.user.Balance - amountOfMoney);

            string date = DateTime.Now.ToString("HH:mm dd.MM.yyyy");

            MySqlCommand cmd2 = new(query2, connection);
            cmd2.Parameters.AddWithValue("@username", username);
            cmd2.Parameters.AddWithValue("@amount", amountOfMoney);
            cmd2.Parameters.AddWithValue("@date", date);
            cmd2.Parameters.AddWithValue("@type", "withdrawn");

            connection.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            connection.Close();

            BankManagment.user.Balance -= amountOfMoney;
            AddLog(date, "withdrawn", amountOfMoney);
        }

        private static List<TransactionLogs> GetLogs(string username)
        {
            List<TransactionLogs> logs = new List<TransactionLogs>();

            //id, date, type, amount
            string query = @"
            SELECT * FROM logs
            WHERE username = @username;
            ";

            MySqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@username", username);

            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string date = reader["date"].ToString();
                string type = reader["type"].ToString();
                double amount = double.Parse(reader["amount"].ToString());
                TransactionLogs logsa = new(id, date, type, amount);
                logs.Add(logsa);
            }
            connection.Close();
            return logs;
        }

        private static void AddLog(string date, string type, double amount)
        {
            TransactionLogs log = new(BankManagment.user.Logs.Last().Id + 1, date, type, amount);
            BankManagment.user.Logs.Add(log);
        }
    }
}
