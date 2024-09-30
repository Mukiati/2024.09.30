using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _2024._09._30
{
    public class databasehandler
    {
        MySqlConnection connection;
        public databasehandler()
        {
            string username = "root";
            string password = "";
            string host = "localhost";
            string dbname = "Trabant";
            string connectionstring = $"username={username};password={password};host={host};database={dbname}";

            connection = new MySqlConnection(connectionstring);

        }
        public void add
        public void ReadAll()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM autok";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    int id = read.GetInt32(read.GetOrdinal("id"));
                    string make = read.GetString(read.GetOrdinal("make"));
                    string model = read.GetString(read.GetOrdinal("model"));
                    string color = read.GetString(read.GetOrdinal("color"));
                    int year = read.GetInt32(read.GetOrdinal("year"));
                    int power = read.GetInt32(read.GetOrdinal("power"));
                    car onecar = new car();
                    onecar.id = id;
                    onecar.type = make;
                    onecar.model = model;
                    onecar.color = color;
                    onecar.year = year;
                    onecar.hp = power;
                    car.cars.Add(onecar);

                }
                read.Close();
                command.Dispose();
                connection.Close();
                MessageBox.Show("siker");
            }
            catch (Exception e)
            {

                MessageBox.Show("Hiba"+e.Message);
                MessageBox.Show(e.Message,"Hiba");
            }
        }
    }
}
