using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C968_Project
{
    public partial class MainForm : Form
    {
        public int currentIndex;
        public Part currentSelectedPart;
        public int productIndex;
        public Product currentSelectedProduct;

        
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = Inventory.Products;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || (int.TryParse(textBox1.Text, out int n)))
            {
                searchButton1.Enabled = false;
                textBox1.BackColor = Color.Salmon;
            }
            else
            {
                searchButton1.Enabled = true;
                textBox1.BackColor = Color.White;
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddPartForm f2 = new AddPartForm(this);
            f2.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dataGridView1.CurrentCell.RowIndex;
            currentSelectedPart = Inventory.AllParts[currentIndex];
        }

        private void modButton1_Click(object sender, EventArgs e)
        {
            if (currentSelectedPart == null)
            {
                MessageBox.Show("No Part selected. Please Select a Part.", "Error");
            }
            else
            {
                ModPartForm f3 = new ModPartForm(this);
                f3.Show();
                this.Hide();
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Any())
            {
                DialogResult deletePartDialog = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part?", MessageBoxButtons.YesNo);

                if (deletePartDialog == DialogResult.Yes)
                {
                    int selectedPart = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                    Inventory.deletePart(Inventory.lookupPart(selectedPart));
                }
                else if (deletePartDialog == DialogResult.No)
                {
                    //do nothing
                }
            }
            else
            {
                MessageBox.Show("There are no parts to delete.", "Nothing Selected");
            }
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            AddProdForm f4 = new AddProdForm(this);
            f4.Show();
            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            bool found = false;
            if (textBox1.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Green;
            bool found = false;
            if (textBox2.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(textBox2.Text.ToUpper()))
                    {
                        dataGridView2.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || (int.TryParse(textBox2.Text, out int n)))
            {
                searchButton2.Enabled = false;
                textBox2.BackColor = Color.Salmon;
            }
            else
            {
                searchButton2.Enabled = true;
                textBox2.BackColor = Color.White;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIndex = dataGridView2.CurrentCell.RowIndex;
            currentSelectedProduct = Inventory.Products[productIndex];
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if(currentSelectedProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete Products with Associated Parts. Remove associated parts before deleting product.", "Error");
            }
            else
            {
                DialogResult deleteProductDialog = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product?", MessageBoxButtons.YesNo);
                if (deleteProductDialog == DialogResult.Yes)
                {
                    Inventory.Products.Remove(currentSelectedProduct);
                }

                else if (deleteProductDialog == DialogResult.No)
                {
                    //do nothing
                }
            }

        }

        private void modifyButton2_Click(object sender, EventArgs e)
        {
            if(currentSelectedProduct == null)
            {
                MessageBox.Show("No Product has been selected, please select a Product.", "Error");
            }
            else
            {
                this.Hide();
                ModProdForm f5 = new ModProdForm(this);
                f5.Show();
            }
        }

    }
}
