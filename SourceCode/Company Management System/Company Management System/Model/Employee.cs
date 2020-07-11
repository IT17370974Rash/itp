using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Company_Management_System
{
    class Employee
    {
        private readonly string COMMAND_LOGIN = "COMMANDLOGIN";
        private readonly string COMMAND_REGISTER = "COMMANDREGISTER";
        private int _empno;
        private string _fname;
        private string _lname;
        private string _nic;
        private string _address;
        private Int64 _contact;
        private string _username;
        private DateTime _dob;
        private double _rate;

        public Employee()
        {

        }

        public Employee(int empno, string fname, string lname, string nic, string address, Int64 contact, string username, DateTime dob, double rate)
        {
            this._empno = empno;
            this._fname = fname;
            this._lname = lname;
            this._nic = nic;
            this._address = address;
            this._contact = contact;
            this._username = username;
            this._dob = dob;
            this._rate = rate;
        }

        public bool Login(string username, string password)
        {
            bool state = false;

            MySqlConnection connection = DatabaseConnection.GetConnection();

            try
            {
                connection.Open();
                
                MySqlCommand command = DatabaseConnection.GetCommand(COMMAND_LOGIN);
                command.Prepare();
                command.Parameters.AddWithValue("@username", username);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(BCrypt.Net.BCrypt.EnhancedVerify(password, reader.GetString("password"),BCrypt.Net.HashType.SHA512))
                        {
                            Session.Employee = new Employee(reader.GetInt32("empno"), reader.GetString("fname"), reader.GetString("lname"), reader.GetString("nic"), reader.GetString("address"),reader.GetInt64("contact"),reader.GetString("username"),reader.GetDateTime("dob"),0);
                            return true;
                        }
                    }
                }
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return state;
        }

        public bool Register(string fname, string lname, string address, string nic, int contact, string username, string password, DateTime dob, double rate)
        {
            this._rate = rate;
            this._address = address;
            this._fname = fname;
            this._lname = lname;
            this._nic = nic;
            this._contact = contact;
            this._username = username;
            this._dob = dob;

            MySqlConnection connection = DatabaseConnection.GetConnection();
            MySqlCommand command = DatabaseConnection.GetCommand(COMMAND_REGISTER);
            command.Prepare();

            command.Parameters.AddWithValue("@fname",fname);
            command.Parameters.AddWithValue("@lname",lname);
            command.Parameters.AddWithValue("@nic",nic);
            command.Parameters.AddWithValue("@dob",dob);
            command.Parameters.AddWithValue("@address",address);
            command.Parameters.AddWithValue("@contact",contact);
            command.Parameters.AddWithValue("@rate",rate);
            command.Parameters.AddWithValue("@password",password);
            command.Parameters.AddWithValue("@username", username);

            if(command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
