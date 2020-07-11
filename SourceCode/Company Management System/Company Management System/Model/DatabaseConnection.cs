using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Company_Management_System
{
    public class DatabaseConnection
    {
        private static MySqlConnection connection;
        private readonly static string commandLogin = Properties.Resources.login;
        private readonly static string commandRegister = Properties.Resources.register;
        private readonly static string commandAddMaterial = Properties.Resources.addmaterial;
        private readonly static string commandLoadMaterial = Properties.Resources.loeadmaterial;
        private readonly static string commandGetMaterial = Properties.Resources.getmaterial;

        private DatabaseConnection()
        {
            connection = null;
        }

        public static MySqlConnection GetConnection()
        {
            if(connection == null)
            {
                try
                {
                    connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["databaseconnection"].ConnectionString);
                }catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    Miscellaneous.Shutdown();
                }
            }
            return connection;
        }

        public static MySqlCommand GetCommand(string command)
        {
            if (command.Equals("commandlogin", StringComparison.OrdinalIgnoreCase))
            {
                return new MySqlCommand(commandLogin, connection);
            }else if (command.Equals("register", StringComparison.OrdinalIgnoreCase))
            {
                return new MySqlCommand(commandRegister, connection);
            }else if (command.Equals("addmaterial",StringComparison.OrdinalIgnoreCase))
            {
                return new MySqlCommand(commandAddMaterial, connection);
            }else if (command.Equals("loadmaterial", StringComparison.OrdinalIgnoreCase))
            {
                return new MySqlCommand(commandLoadMaterial, connection);
            }
            else if (command.Equals("getmaterial", StringComparison.OrdinalIgnoreCase))
            {
                return new MySqlCommand(commandGetMaterial, connection);
            }
            return null;
        }
    }
}
