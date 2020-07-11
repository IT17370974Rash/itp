using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Company_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            label1.Location = new Point(Convert.ToInt32(this.Width / 2 - label1.Width / 2), Convert.ToInt32(this.Height / 20 - label1.Height / 2));
            groupBox1.Location = new Point(Convert.ToInt32(this.Width / 2 - groupBox1.Width / 2), Convert.ToInt32(this.Height / 2 - groupBox1.Height / 2));
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Miscellaneous.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();

                try
                {
                    connection.Open();
                    MySqlCommand command = DatabaseConnection.GetCommand("REGISTER");
                    command.Prepare();
                    command.Parameters.AddWithValue("@fname",fname.Text);
                    command.Parameters.AddWithValue("@lname",lname.Text);
                    command.Parameters.AddWithValue("@address",address.Text);
                    command.Parameters.AddWithValue("@nic",nic.Text);
                    command.Parameters.AddWithValue("@contact",Convert.ToInt64(contact.Text));
                    command.Parameters.AddWithValue("@dob",dob.SelectionRange.Start.Date);
                    command.Parameters.AddWithValue("@username",username.Text);
                    command.Parameters.AddWithValue("@password",BCrypt.Net.BCrypt.EnhancedHashPassword(password.Text,BCrypt.Net.HashType.SHA512,14));

                    MessageBox.Show("OK");
                    if(command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Registration successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.isFirst = false;
                        Properties.Settings.Default.Save();
                        Form1 form = new Form1();
                        this.Hide();
                        form.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (sender.Equals(fname))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    lname.Focus();
                }
            }else if (sender.Equals(lname))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    address.Focus();
                }
            }
            else if (sender.Equals(address))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    contact.Focus();
                }
            }
            else if (sender.Equals(contact))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    nic.Focus();
                }
            }
            else if (sender.Equals(nic))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    username.Focus();
                }
            }
            else if (sender.Equals(username))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    password.Focus();
                }
            }
            else if (sender.Equals(password))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dob.Focus();
                }
            }
            else if (sender.Equals(dob))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    registerBtn.Focus();
                }
            }
            else if (sender.Equals(registerBtn))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    registerBtn.PerformClick();
                }
            }
        }

        private bool checkInputs()
        {
            bool state = false;
            string message = "";

            if(Regex.IsMatch(fname.Text, @"^[a-zA-Z]+$"))
            {
                if (Regex.IsMatch(lname.Text, @"^[a-zA-Z]+$"))
                {
                    if (Regex.IsMatch(address.Text, @"^[a-zA-Z0-9_, ]+$"))
                    {
                        if (Regex.IsMatch(contact.Text, @"^[0-9-]+$") && contact.Text.Length == 10)
                        {
                            if (Regex.IsMatch(nic.Text, @"^[0-9V]+$") && nic.Text.Length == 10)
                            {
                                if (Regex.IsMatch(username.Text, @"^[a-zA-Z0-9_]+$"))
                                {
                                    if (Regex.IsMatch(password.Text, @"^[a-zA-Z0-9_]+$"))
                                    {
                                        state = true;
                                    }
                                    else
                                    {
                                        message += "Invalid password\n";
                                    }
                                }
                                else
                                {
                                    message += "Invalid password\n";
                                }
                            }
                            else
                            {
                                message += "Invalid nic\n";
                            }
                        }
                        else
                        {
                            message += "Invalid contact\n";
                        }
                    }
                    else
                    {
                        message += "Invalid address\n";
                    }
                }
                else
                {
                    message += "Invalid last name\n";
                }
            }
            else
            {
                message += "Invalid first name\n";
            }

            if(message.Length != 0)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return state;
        } 
    }
}
