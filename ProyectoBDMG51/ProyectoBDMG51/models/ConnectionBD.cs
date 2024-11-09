﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoBDMG51.models
{
    class ConnectionBD
    {
        public MySqlConnection connManager = new MySqlConnection();
        string server = "127.0.0.1;";
        string database = "proyectobdm;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database} Uid={user} password={pass}");
            return connManager;
        }

        public void ConnectOpened()
        {
            connManager.Open();
        }

        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }

        internal bool ExecuteQuery(string sql, string archivoRecurso)
        {
            throw new NotImplementedException();
        }

        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOOR" + w.Message);

                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }
    }
}
