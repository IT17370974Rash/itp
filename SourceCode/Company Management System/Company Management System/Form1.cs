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
using System.Diagnostics;

namespace Company_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            submit.Location = new Point(Convert.ToInt32(this.Width / 2 - submit.Width / 2),147);
        }

        private void Lookup()
        {
            if (Properties.Settings.Default.isFirst)
            {
                RegisterForm form = new RegisterForm();
                form.Show();
                this.Hide();
            }
        }

        private void usernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                passwordText.Focus();
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                submit.PerformClick();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DatabaseConnection.GetConnection();

            try
            {
                /*if (Regex.IsMatch(usernameText.Text, @"^[a-zA-Z0-9_]+$")){
                    if (Regex.IsMatch(passwordText.Text, @"^[a-zA-Z0-9!@#$%^&*]+$"))
                    {
                        Employee employee = new Employee();
                        if(employee.login(usernameText.Text, passwordText.Text))
                        {
                            this.Hide();
                            Main main = new Main();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }*/
                
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Program will terminate.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Miscellaneous.Shutdown();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Lookup();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Miscellaneous.Shutdown();
        }
    }
}
