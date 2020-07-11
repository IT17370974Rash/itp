using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            hideLayouts();
        }

        private void hideLayouts()
        {
            employeePanel.Hide();
            leavePanel.Hide();
            inventoryPanel.Hide();
            orderPanel.Hide();
            financePanel.Hide();
            deliveryPanel.Hide();
            customerPanel.Hide();
            supplierPanel.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            splitContainer1_Panel1_Resize(sender,e);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Miscellaneous.Shutdown();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(splitContainer1.Panel1.Height / 10);
            pictureBox1.Height = height*2;
            employeeBtn.Height = height;
            attendanceBtn.Height = height;
            inventoryBtn.Height = height;
            orderBtn.Height = height;
            btnDelivery.Height = height;
            btnSupplier.Height = height;
            btnCustomer.Height = height;
            btnFinance.Height = height;
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            hideLayouts();
            employeePanel.Dock = DockStyle.Fill;
            employeePanel.Show();

        }

        private void AttendanceBtn_Click(object sender, EventArgs e)
        {
            hideLayouts();
            leavePanel.Dock = DockStyle.Fill;
            leavePanel.Show();
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            hideLayouts();
            inventoryPanel.Dock = DockStyle.Fill;
            inventoryPanel.Show();
            searchRawMaterial.AutoCompleteCustomSource.Clear();
            searchRawMaterial.AutoCompleteCustomSource = RawMaterial.LoadSearch();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            hideLayouts();
            orderPanel.Dock = DockStyle.Fill;
            orderPanel.Show();
        }

        private void BtnDelivery_Click(object sender, EventArgs e)
        {
            hideLayouts();
            deliveryPanel.Dock = DockStyle.Fill;
            deliveryPanel.Show();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            hideLayouts();
            supplierPanel.Dock = DockStyle.Fill;
            supplierPanel.Show();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            hideLayouts();
            customerPanel.Dock = DockStyle.Fill;
            customerPanel.Show();
        }

        private void BtnFinance_Click(object sender, EventArgs e)
        {
            hideLayouts();
            financePanel.Dock = DockStyle.Fill;
            financePanel.Show();
        }

        private void AddMaterialBtn_Click(object sender, EventArgs e)
        {
            RawMaterial rawMaterial = new RawMaterial();
            if(Miscellaneous.Validation.MatchStringNumbers(materialNameTextBox.Text) && Miscellaneous.Validation.MatchStringWithDot(materialDescriptionTextBox.Text))
            {
                if (rawMaterial.AddRawMaterial(materialNameTextBox.Text,materialDescriptionTextBox.Text))
                {
                    MessageBox.Show("Material Successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    materialDescriptionTextBox.Text = "";
                    materialNameTextBox.Text = "";
                    materialTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Sorry cannot add raw material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Name and Description should only contain letters and white spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void MaterialSearchBtn_Click(object sender, EventArgs e)
        {
            if(searchRawMaterial.Text.Equals( " " ) || searchRawMaterial.Text != null)
            {
                if (Miscellaneous.Validation.MatchString(searchRawMaterial.Text))
                {
                    RawMaterial rawMaterial = RawMaterial.GetRawMaterial(searchRawMaterial.Text);
                    if(rawMaterial != null)
                    {
                        materialTextBox.Text = rawMaterial.Materialid.ToString();
                        materialNameTextBox.Text = rawMaterial.Name;
                        materialDescriptionTextBox.Text = rawMaterial.Description;
                    }
                }
                else
                {
                    MessageBox.Show("Raw materials should only contain letters and white spaces","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SearchRawMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                materialSearchBtn.PerformClick();
        }

        private void MaterialNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool state = true;
            if(materialNameTextBox.Text != "" && state)
            {
                materialTextBox.Text = RawMaterial.NextMaterialID().ToString();
                state = false;
            }
            else
            {
                materialTextBox.Text = "";
                state = true;
            }
        }
    }
}
