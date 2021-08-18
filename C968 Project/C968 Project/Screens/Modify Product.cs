using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace C968_Project
{
    public partial class ModProdForm : Form
    {
        public int productIndex;
        public Product currentSelectedProduct;
        public int currentIndex;
        public Part currentSelectedPart;
        public int associatedIndex;
        public Part currentAssociatedPart;
        public MainForm mainForm;
        BindingList<Part> tempAssociatedParts = new BindingList<Part>();
        
        public ModProdForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            modProdAllParts.DataSource = Inventory.AllParts;
            modProdAssocParts.DataSource = tempAssociatedParts;
            idTextBox3.Text = mainForm.currentSelectedProduct.ProductID.ToString();
            nameTextBox3.Text = mainForm.currentSelectedProduct.Name;
            inventoryTextBox3.Text = mainForm.currentSelectedProduct.InStock.ToString();
            priceTextBox.Text = mainForm.currentSelectedProduct.Price.ToString();
            maxTextBox3.Text = mainForm.currentSelectedProduct.Max.ToString();
            minTextBox3.Text = mainForm.currentSelectedProduct.Min.ToString();
            foreach(Part part in mainForm.currentSelectedProduct.AssociatedParts)
            {
                tempAssociatedParts.Add(part);
            }
        }

        private void modProdCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void idTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox3.Text) || !(int.TryParse(idTextBox3.Text, out int n)))
            {
                idTextBox3.BackColor = Color.Salmon;
                modProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid ID entry, interger values accepted.", "Invalid ID");
            }
            else
            {
                idTextBox3.BackColor = Color.White;
            }
            if (idTextBox3.BackColor == Color.White &&
                nameTextBox3.BackColor == Color.White &&
                inventoryTextBox3.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox3.BackColor == Color.White &&
                minTextBox3.BackColor == Color.White)
            {
                modProdSaveButton.Enabled = true;
            }
        }

        private void nameTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox3.Text) || (int.TryParse(nameTextBox3.Text, out int n)))
            {
                nameTextBox3.BackColor = Color.Salmon;
                modProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid name entry, string values accepted.", "Invalid Name");
            }
            else
            {
                nameTextBox3.BackColor = Color.White;
            }
            if (idTextBox3.BackColor == Color.White &&
                nameTextBox3.BackColor == Color.White &&
                inventoryTextBox3.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox3.BackColor == Color.White &&
                minTextBox3.BackColor == Color.White)
            {
                modProdSaveButton.Enabled = true;
            }
        }

        private void inventoryTextBox3_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(inventoryTextBox3.Text) || !(int.TryParse(inventoryTextBox3.Text, out int n)))
                {
                    inventoryTextBox3.BackColor = Color.Salmon;
                    modProdSaveButton.Enabled = false;
                    MessageBox.Show("Invalid inventory entry, interger values accepted.", "Invalid Inventory");
                }
                else
                {
                    inventoryTextBox3.BackColor = Color.White;
                }
                if (idTextBox3.BackColor == Color.White &&
                    nameTextBox3.BackColor == Color.White &&
                    inventoryTextBox3.BackColor == Color.White &&
                    priceTextBox.BackColor == Color.White &&
                    maxTextBox3.BackColor == Color.White &&
                    minTextBox3.BackColor == Color.White)
                {
                    modProdSaveButton.Enabled = true;
                }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || !(decimal.TryParse(priceTextBox.Text, out decimal n)))
            {
                priceTextBox.BackColor = Color.Salmon;
                modProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid price entry, decimal values accepted.", "Invalid Price");
            }
            else
            {
                priceTextBox.BackColor = Color.White;
            }
            if (idTextBox3.BackColor == Color.White &&
                nameTextBox3.BackColor == Color.White &&
                inventoryTextBox3.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox3.BackColor == Color.White &&
                minTextBox3.BackColor == Color.White)
            {
                modProdSaveButton.Enabled = true;
            }
        }

        private void maxTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxTextBox3.Text) || !(int.TryParse(maxTextBox3.Text, out int n)))
            {
                maxTextBox3.BackColor = Color.Salmon;
                modProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid Max entry, integer values accepted.", "Invalid Maximum");
            }
            else
            {
                maxTextBox3.BackColor = Color.White;
            }
            if (idTextBox3.BackColor == Color.White &&
                nameTextBox3.BackColor == Color.White &&
                inventoryTextBox3.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox3.BackColor == Color.White &&
                minTextBox3.BackColor == Color.White)
            {
                modProdSaveButton.Enabled = true;
            }
        }

        private void minTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox3.Text) || !(int.TryParse(minTextBox3.Text, out int n)))
            {
                minTextBox3.BackColor = Color.Salmon;
                modProdSaveButton.Enabled = false;
                MessageBox.Show("Invalid Min entry, integer values accepted.", "Invalid Minimum");
            }
            else
            {
                minTextBox3.BackColor = Color.White;
            }
            if (idTextBox3.BackColor == Color.White &&
                nameTextBox3.BackColor == Color.White &&
                inventoryTextBox3.BackColor == Color.White &&
                priceTextBox.BackColor == Color.White &&
                maxTextBox3.BackColor == Color.White &&
                minTextBox3.BackColor == Color.White)
            {
                modProdSaveButton.Enabled = true;
            }
        }

        private void modProdAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = modProdAllParts.CurrentCell.RowIndex;
            currentSelectedPart = Inventory.AllParts[currentIndex];
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            tempAssociatedParts.Add(currentSelectedPart);
        }

        private void modProdAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            associatedIndex = modProdAssocParts.CurrentCell.RowIndex;
            currentAssociatedPart = tempAssociatedParts[associatedIndex];
        }
        private void deletePartButton_Click(object sender, EventArgs e)
        {
            if (currentAssociatedPart == null)
            {
                MessageBox.Show("No associated part selected, please select an associated part.", "Error");
            }
            else
            {
                DialogResult deletePartDialog = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part?", MessageBoxButtons.YesNo);
                if (deletePartDialog == DialogResult.Yes)
                {
                    tempAssociatedParts.Remove(currentAssociatedPart);
                }
                else if (deletePartDialog == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

        private void modProdSaveButton_Click(object sender, EventArgs e)
        {
            
            int ProductID = (int.Parse(idTextBox3.Text));
            string ProductName = nameTextBox3.Text;
            decimal Price = (decimal.Parse(priceTextBox.Text));
            int InStock = (int.Parse(inventoryTextBox3.Text));
            int Max = (int.Parse(maxTextBox3.Text));
            int Min = (int.Parse(minTextBox3.Text));
            Product newProduct = new Product(ProductID, ProductName, Price, InStock, Min, Max);
            Inventory.Products.Add(newProduct);
            foreach (Part part in tempAssociatedParts)
            {
                newProduct.AssociatedParts.Add(part);
            }
            

            Inventory.Products.Remove(mainForm.currentSelectedProduct);

            this.Hide();
            mainForm.Show();
        }

        private void searchButton3_Click(object sender, EventArgs e)
        {
            modProdAllParts.ClearSelection();
            modProdAllParts.DefaultCellStyle.SelectionBackColor = Color.Green;
            bool found = false;
            if (modProdSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(modProdSearchBox.Text.ToUpper()))
                    {
                        modProdAllParts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void modProdSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdSearchBox.Text) || (int.TryParse(modProdSearchBox.Text, out int n)))
            {
                searchButton3.Enabled = false;
                modProdSearchBox.BackColor = Color.Salmon;
            }
            else
            {
                searchButton3.Enabled = true;
                modProdSearchBox.BackColor = Color.White;
            }
        }
    }
}
