using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Company_Management_System
{
    class RawMaterial
    {
        public int Materialid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public RawMaterial()
        {
            
        }

        public RawMaterial(int materialid, string name, string description)
        {
            this.Materialid = materialid;
            this.Name = name;
            this.Description = description;
        }

        public static int NextMaterialID()
        {
            MySqlConnection connection = null;
            try
            {
                connection = DatabaseConnection.GetConnection();
                connection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT MAX(material_id) as id FROM raw_material", connection);
                mySqlCommand.Prepare();

                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int next = dataReader.GetInt32(0);
                    return ++next;
                }
                
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return 0;
        }

        public bool AddRawMaterial(string name, string description)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();

                MySqlCommand mySqlCommand = DatabaseConnection.GetCommand("addmaterial");
                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@name", name);
                mySqlCommand.Parameters.AddWithValue("@description", description);

                if(mySqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Add Raw MAterial Error: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return false;
        }

        public static RawMaterial GetRawMaterial(string name)
        {
            MySqlConnection connection = null;
            try
            {
                connection = DatabaseConnection.GetConnection();
                connection.Open();
                MySqlCommand command = DatabaseConnection.GetCommand("getmaterial");
                command.Prepare();
                command.Parameters.AddWithValue("@name",name);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return new RawMaterial(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No records found!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return null;
        }

        public static System.Windows.Forms.AutoCompleteStringCollection LoadSearch()
        {
            System.Windows.Forms.AutoCompleteStringCollection collection = new System.Windows.Forms.AutoCompleteStringCollection();
            MySqlConnection connection = null;
            try
            {
                connection = DatabaseConnection.GetConnection();
                connection.Open();
                MySqlCommand command = DatabaseConnection.GetCommand("loadmaterial");
                command.Prepare();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        collection.Add(reader.GetString(0));
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No records found!","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Asterisk);
                }
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            return collection;
        }
    }
}
