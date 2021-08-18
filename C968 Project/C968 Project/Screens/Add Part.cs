using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C968_Project
{
    public partial class AddPartForm : Form
    {
        public MainForm mainForm;
        public AddPartForm()
        {
            InitializeComponent();
        }

        public AddPartForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }


        private void addCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
            
        }

        private void inHouseRadio1_CheckedChanged(object sender, EventArgs e)
        {
            machineTextBox1.Clear();
            machineLabel1.Text = "Machine ID";
                  
        }


        private void outsourcedRadio2_CheckedChanged(object sender, EventArgs e)
        {
            machineLabel1.Text = "Company Name";

        }

        private void idTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox1.Text) || !(int.TryParse(idTextBox1.Text, out int n)))
            {
                idTextBox1.BackColor = Color.Salmon;
                addSaveButton.Enabled = false;
                MessageBox.Show("Invalid inventory entry, interger values accepted.", "Invalid Inventory");
            }
            else
            {
                idTextBox1.BackColor = Color.White;
            }
            if (nameTextBox1.BackColor == Color.White &&
                inventoryTextBox1.BackColor == Color.White &&
                pcTextBox1.BackColor == Color.White &&
                maxTextBox1.BackColor == Color.White &&
                minTextBox1.BackColor == Color.White)
            {
                addSaveButton.Enabled = true;
            }
        }

        private void nameTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(nameTextBox1.Text)||int.TryParse(nameTextBox1.Text, out int n))
            {
                nameTextBox1.BackColor = Color.Salmon;
                addSaveButton.Enabled = false;
                MessageBox.Show("Invalid Name Entry. Characters A-Z permitted.", "Invalid Name");
            }
            else
            {
                nameTextBox1.BackColor = Color.White;
                addSaveButton.Enabled = true;
            }
            if (nameTextBox1.BackColor == Color.White &&
                inventoryTextBox1.BackColor == Color.White &&
                pcTextBox1.BackColor == Color.White &&
                maxTextBox1.BackColor == Color.White &&
                minTextBox1.BackColor == Color.White)
            {
                addSaveButton.Enabled = true;
            }
        }

        private void inventoryTextBox1_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(inventoryTextBox1.Text) || !(int.TryParse(inventoryTextBox1.Text, out int n)))
                {
                    inventoryTextBox1.BackColor = Color.Salmon;
                    addSaveButton.Enabled = false;
                    MessageBox.Show("Invalid inventory entry, interger values accepted.", "Invalid Inventory");
                }
                else
                {
                    inventoryTextBox1.BackColor = Color.White;
                }
                if (nameTextBox1.BackColor == Color.White &&
                    inventoryTextBox1.BackColor == Color.White &&
                    pcTextBox1.BackColor == Color.White &&
                    maxTextBox1.BackColor == Color.White &&
                    minTextBox1.BackColor == Color.White)
                {
                    addSaveButton.Enabled = true;
                }
            
        }


        private void pcTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pcTextBox1.Text) || !(decimal.TryParse(pcTextBox1.Text, out decimal n)))
            {
                pcTextBox1.BackColor = Color.Salmon;
                addSaveButton.Enabled = false;
                MessageBox.Show("Invalid inventory entry, decimal values accepted.", "Invalid Inventory");
            }
            else
            {
                pcTextBox1.BackColor = Color.White;
            }
            if (nameTextBox1.BackColor == Color.White &&
                inventoryTextBox1.BackColor == Color.White &&
                pcTextBox1.BackColor == Color.White &&
                maxTextBox1.BackColor == Color.White &&
                minTextBox1.BackColor == Color.White)
            {
                addSaveButton.Enabled = true;
            }
        }

        private void maxTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(maxTextBox1.Text)||!(int.TryParse(maxTextBox1.Text, out int n)))
            {
                maxTextBox1.BackColor = Color.Salmon;
                addSaveButton.Enabled = false;
                MessageBox.Show("Invalid entry, intergers required.", "Invalid Entry");
            }
            else
            {
                maxTextBox1.BackColor = Color.White;
            }
            if (nameTextBox1.BackColor == Color.White &&
                inventoryTextBox1.BackColor == Color.White &&
                pcTextBox1.BackColor == Color.White &&
                maxTextBox1.BackColor == Color.White &&
                minTextBox1.BackColor == Color.White)
            {
                addSaveButton.Enabled = true;
            }

        }

        private void minTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox1.Text) || !(int.TryParse(minTextBox1.Text, out int n)))
            {
                minTextBox1.BackColor = Color.Salmon;
                addSaveButton.Enabled = false;
                MessageBox.Show("Invalid entry, intergers required.", "Invalid Entry");
            }
            else
            {
                minTextBox1.BackColor = Color.White;
            }
            if (nameTextBox1.BackColor == Color.White &&
                inventoryTextBox1.BackColor == Color.White &&
                pcTextBox1.BackColor == Color.White &&
                maxTextBox1.BackColor == Color.White &&
                minTextBox1.BackColor == Color.White)
            {
                addSaveButton.Enabled = true;
            }
        }

        private void machineTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(machineTextBox1.Text)||(inHouseRadio1.Checked && !(int.TryParse(machineTextBox1.Text, out int n)))||
                outsourcedRadio2.Checked && int.TryParse(machineTextBox1.Text, out int s))
            {
                machineTextBox1.BackColor = Color.Salmon;
                addSaveButton.Enabled = false;
            }
            else
            {
                machineTextBox1.BackColor = Color.White;
            }
            if (nameTextBox1.BackColor == Color.White &&
              inventoryTextBox1.BackColor == Color.White &&
              pcTextBox1.BackColor == Color.White &&
              maxTextBox1.BackColor == Color.White &&
              minTextBox1.BackColor == Color.White)
            {
                addSaveButton.Enabled = true;
            }
        }

        private void addSaveButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            InHousePart inhouse;
            OSPart outsource;
        
            if(Convert.ToInt32(maxTextBox1.Text) > Convert.ToInt32(minTextBox1.Text))
            {
                if (inHouseRadio1.Checked)
                {
                    inhouse = new InHousePart(Convert.ToInt32(idTextBox1.Text), nameTextBox1.Text, Convert.ToDecimal(pcTextBox1.Text), 
                        Convert.ToInt32(inventoryTextBox1.Text), Convert.ToInt32(minTextBox1.Text), Convert.ToInt32(maxTextBox1.Text),
                        Convert.ToInt32(machineTextBox1.Text));
                    Inventory.addPart(inhouse);
                }
                                else if (outsourcedRadio2.Checked)
                {
                    outsource = new OSPart(Convert.ToInt32(idTextBox1.Text), nameTextBox1.Text, Convert.ToDecimal(pcTextBox1.Text),
                        Convert.ToInt32(inventoryTextBox1.Text), Convert.ToInt32(minTextBox1.Text), Convert.ToInt32(maxTextBox1.Text),
                        machineTextBox1.Text);
                    Inventory.addPart(outsource);
                }
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Your min value was greater than the max value.", "Error");
            }
        }
    }
}
