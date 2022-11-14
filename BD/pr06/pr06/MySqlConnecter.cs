using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace pr06
{
    internal class MySqlConnecter
    {
        private MySqlConnection _dbConection;
        private string _connectionString;
        public MySqlConnecter(string connectionString)
        {
            _connectionString = connectionString;
            _dbConection = new MySqlConnection(connectionString);
        }
        public DataTable ReturnQueryTable(string query)
        {
            _dbConection.Open();
            MySqlCommand command = new MySqlCommand(query, _dbConection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            _dbConection.Close();
            return table;
        }
    }
}
