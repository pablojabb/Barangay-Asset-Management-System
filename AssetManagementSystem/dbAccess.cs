using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public class dbAccess
    {
        private readonly string connectionString;

        public dbAccess(string dbPath = "database.db")
        {
            connectionString = $"Data Source={dbPath};";
            InitializeDatabase(dbPath);
        }

        // Create database file if it doesn't exist
        private void InitializeDatabase(string dbPath)
        {
            if (!System.IO.File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
        }

        // Open connection
        private SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Execute INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        // Execute SELECT and return as DataTable
        public DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        // Execute scalar (e.g., COUNT, MAX, etc.)
        public object ExecuteScalar(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }

     

    }


}

