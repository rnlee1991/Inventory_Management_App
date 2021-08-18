using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace C968_Project
{
    public partial class AddProdForm : Form
    {
        BindingList<Part> tempPartsList = new BindingList<Part>();
        public int currentIndex;
        public Part currentSelectedPart;
        public int assocIndex;
        public Part currentAssocPart;

        public MainForm mainForm;
        public AddProdForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            addProdAllParts.DataSource = Inventory.AllParts;
            addProdAssocParts.DataSource = tempPartsList;

           
        }

        private void addProdCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void idTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox4.Text) || !(int.TryParse(idTextBox4.Text, out int n)))
            {
                idTextBox4.BackColor = Color.Salmon;
                addProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid ID entry, interger values accepted.", "Invalid ID");
            }
            else
            {
                idTextBox4.BackColor = Color.White;
            }
            if (idTextBox4.BackColor == Color.White &&
                nameTextBox4.BackColor == Color.White &&
                inventoryTextBox4.BackColor == Color.White &&
                priceTextBox2.BackColor == Color.White &&
                maxTextBox4.BackColor == Color.White &&
                minTextBox4.BackColor == Color.White)
            {
                addProdSaveButton.Enabled = true;
            }
        }

        private void nameTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox4.Text) || (int.TryParse(nameTextBox4.Text, out int n)))
            {
                nameTextBox4.BackColor = Color.Salmon;
                addProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid name entry, string values accepted.", "Invalid Name");
            }
            else
            {
                nameTextBox4.BackColor = Color.White;
            }
            if (idTextBox4.BackColor == Color.White &&
                nameTextBox4.BackColor == Color.White &&
                inventoryTextBox4.BackColor == Color.White &&
                priceTextBox2.BackColor == Color.White &&
                maxTextBox4.BackColor == Color.White &&
                minTextBox4.BackColor == Color.White)
            {
                addProdSaveButton.Enabled = true;
            }
        }

        private void inventoryTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryTextBox4.Text) || !(int.TryParse(inventoryTextBox4.Text, out int n)))
            {
                inventoryTextBox4.BackColor = Color.Salmon;
                addProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid inventory entry, interger values accepted.", "Invalid Inventory");
            }
            else
            {
                inventoryTextBox4.BackColor = Color.White;
            }
            if (idTextBox4.BackColor == Color.White &&
                nameTextBox4.BackColor == Color.White &&
                inventoryTextBox4.BackColor == Color.White &&
                priceTextBox2.BackColor == Color.White &&
                maxTextBox4.BackColor == Color.White &&
                minTextBox4.BackColor == Color.White)
            {
                addProdSaveButton.Enabled = true;
            }
        }

        private void priceTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTextBox2.Text) || !(decimal.TryParse(priceTextBox2.Text, out decimal n)))
            {
                priceTextBox2.BackColor = Color.Salmon;
                addProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid price entry, decimal values accepted.", "Invalid Price");
            }
            else
            {
                priceTextBox2.BackColor = Color.White;
            }
            if (idTextBox4.BackColor == Color.White &&
                nameTextBox4.BackColor == Color.White &&
                inventoryTextBox4.BackColor == Color.White &&
                priceTextBox2.BackColor == Color.White &&
                maxTextBox4.BackColor == Color.White &&
                minTextBox4.BackColor == Color.White)
            {
                addProdSaveButton.Enabled = true;
            }
        }

        private void maxTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxTextBox4.Text) || !(int.TryParse(maxTextBox4.Text, out int n)))
            {
                maxTextBox4.BackColor = Color.Salmon;
                addProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid Max entry, integer values accepted.", "Invalid Maximum");
            }
            else
            {
                maxTextBox4.BackColor = Color.White;
            }
            if (idTextBox4.BackColor == Color.White &&
                nameTextBox4.BackColor == Color.White &&
                inventoryTextBox4.BackColor == Color.White &&
                priceTextBox2.BackColor == Color.White &&
                maxTextBox4.BackColor == Color.White &&
                minTextBox4.BackColor == Color.White)
            {
                addProdSaveButton.Enabled = true;
            }
        }

        private void minTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox4.Text) || !(int.TryParse(minTextBox4.Text, out int n)))
            {
                minTextBox4.BackColor = Color.Salmon;
                addProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid Min entry, integer values accepted.", "Invalid Minimum");
            }
            else
            {
                minTextBox4.BackColor = Color.White;
            }
            if (idTextBox4.BackColor == Color.White &&
                nameTextBox4.BackColor == Color.White &&
                inventoryTextBox4.BackColor == Color.White &&
                priceTextBox2.BackColor == Color.White &&
                maxTextBox4.BackColor == Color.White &&
                minTextBox4.BackColor == Color.White)
            {
                addProdSaveButton.Enabled = true;
            }
        }

        private void addProdSaveButton_Click(object sender, EventArgs e)
        {
            Product newProd;
            if(Convert.ToInt32(maxTextBox4.Text) > Convert.ToInt32(minTextBox4.Text))
            {
               newProd = new Product(Convert.ToInt32(idTextBox4.Text), nameTextBox4.Text, Convert.ToDecimal(priceTextBox2.Text), Convert.ToInt32(inventoryTextBox4.Text),
               Convert.ToInt32(minTextBox4.Text), Convert.ToInt32(maxTextBox4.Text));
                
                Inventory.Products.Add(newProd);
                foreach (Part part in tempPartsList)
                {
                    newProd.AssociatedParts.Add(part);
                }
                
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Your min value was greater than your max value.", "Error");
            }
        }
        private void addProdAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = addProdAllParts.CurrentCell.RowIndex;
            currentSelectedPart = Inventory.AllParts[currentIndex];
        }

        private void addPartButton2_Click(object sender, EventArgs e)
        {
            tempPartsList.Add(currentSelectedPart); 
        }
        private void addProdAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            assocIndex = addProdAssocParts.CurrentCell.RowIndex;
            currentAssocPart = tempPartsList[assocIndex];
        }

        private void deletePartButton2_Click(object sender, EventArgs e)
        {
          
            DialogResult deletePartDialog = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part?", MessageBoxButtons.YesNo);
            if(deletePartDialog == DialogResult.Yes)
            {
                tempPartsList.Remove(currentAssocPart);
            }
            else if (deletePartDialog == DialogResult.No)
            {
                //do nothing
            }
        }

        private void searchButton4_Click(object sender, EventArgs e)
        {
            addProdAllParts.ClearSelection();
            addProdAllParts.DefaultCellStyle.SelectionBackColor = Color.Green;
            bool found = false;
            if (addProdSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(addProdSearchBox.Text.ToUpper()))
                    {
                        addProdAllParts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void addProdSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdSearchBox.Text) || (int.TryParse(addProdSearchBox.Text, out int n)))
            {
                searchButton4.Enabled = false;
                addProdSearchBox.BackColor = Color.Salmon;
            }
            else
            {
                searchButton4.Enabled = true;
                addProdSearchBox.BackColor = Color.White;
            }
        }
    }
}
