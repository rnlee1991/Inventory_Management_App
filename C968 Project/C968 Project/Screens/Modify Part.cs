using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C968_Project
{
    public partial class ModPartForm : Form
    {
      
        public MainForm mainForm;
        public ModPartForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            idTextBox2.Text = mainForm.currentSelectedPart.PartID.ToString();
            nameTextBox2.Text = mainForm.currentSelectedPart.Name;
            inventoryTextBox2.Text = mainForm.currentSelectedPart.InStock.ToString();
            pcTextBox2.Text = mainForm.currentSelectedPart.Price.ToString();
            maxTextBox2.Text = mainForm.currentSelectedPart.Max.ToString();
            minTextBox2.Text = mainForm.currentSelectedPart.Min.ToString();
            if (mainForm.currentSelectedPart is InHousePart)
            {
                InHousePart p = (InHousePart)mainForm.currentSelectedPart;
                inHouseRadio2.Checked = true;
                machineTextBox2.Text = p.MachineID.ToString();
            }
            else
            {
                OSPart o = (OSPart)mainForm.currentSelectedPart;
                outSourcedRadio2.Checked = true;
                machineTextBox2.Text = o.CompanyName;
            }
        }

        private void modCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void inHouseRadio2_CheckedChanged(object sender, EventArgs e)
        {
            machineLabel2.Text = "Machine ID";
            machineTextBox2.Clear();
        }

        private void outSourcedRadio2_CheckedChanged_1(object sender, EventArgs e)
        {
            machineLabel2.Text = "Company Name";
        }

        private void nameTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox2.Text) || (int.TryParse(nameTextBox2.Text, out int n)))
            {
                nameTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
                MessageBox.Show("Invalid name entry, A-Z values accepted.", "Invalid Name");
            }
            else
            {
                nameTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
                inventoryTextBox2.BackColor == Color.White &&
                pcTextBox2.BackColor == Color.White &&
                maxTextBox2.BackColor == Color.White &&
                minTextBox2.BackColor == Color.White &&
                machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
        }

        private void inventoryTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryTextBox2.Text) || !(int.TryParse(inventoryTextBox2.Text, out int n)))
            {
                inventoryTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
                MessageBox.Show("Invalid Inventory entry, integer values accepted.", "Invalid Inventory");
            }
            else
            {
                inventoryTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
             inventoryTextBox2.BackColor == Color.White &&
             pcTextBox2.BackColor == Color.White &&
             maxTextBox2.BackColor == Color.White &&
             minTextBox2.BackColor == Color.White &&
             machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
            else
            {
                modSaveButton.Enabled = false;
            }
        }

        private void pcTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pcTextBox2.Text) || !(decimal.TryParse(pcTextBox2.Text, out decimal n)))
            {
                pcTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
                MessageBox.Show("Invalid inventory entry, decimal values accepted.", "Invalid Price");
            }
            else
            {
                pcTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
              inventoryTextBox2.BackColor == Color.White &&
              pcTextBox2.BackColor == Color.White &&
              maxTextBox2.BackColor == Color.White &&
              minTextBox2.BackColor == Color.White &&
              machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
            else
            {
                modSaveButton.Enabled = false;
            }
        }

        private void maxTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxTextBox2.Text) || !(int.TryParse(maxTextBox2.Text, out int n)))
            {
                maxTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
                MessageBox.Show("Invalid entry, intergers required.", "Invalid Entry");
            }
            else
            {
                maxTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
                 inventoryTextBox2.BackColor == Color.White &&
                 pcTextBox2.BackColor == Color.White &&
                 maxTextBox2.BackColor == Color.White &&
                 minTextBox2.BackColor == Color.White &&
                 machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
            else
            {
                modSaveButton.Enabled = false;
            }
        }

        private void minTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox2.Text) || !(int.TryParse(minTextBox2.Text, out int n)))
            {
                minTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
                MessageBox.Show("Invalid entry, intergers required.", "Invalid Entry");
            }
            else
            {
                minTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
               inventoryTextBox2.BackColor == Color.White &&
               pcTextBox2.BackColor == Color.White &&
               maxTextBox2.BackColor == Color.White &&
               minTextBox2.BackColor == Color.White &&
               machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
            else
            {
                modSaveButton.Enabled = false;
            }
        }

        private void machineTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(machineTextBox2.Text) || (inHouseRadio2.Checked && !(int.TryParse(machineTextBox2.Text, out int n))) ||
           outSourcedRadio2.Checked && int.TryParse(machineTextBox2.Text, out int s))
            {
                machineTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
            }
            else
            {
                machineTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
             inventoryTextBox2.BackColor == Color.White &&
             pcTextBox2.BackColor == Color.White &&
             maxTextBox2.BackColor == Color.White &&
             minTextBox2.BackColor == Color.White &&
             machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
            else
            {
                modSaveButton.Enabled = false;
            }
        }

        private void idTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox2.Text) || !(int.TryParse(idTextBox2.Text, out int n)))
            {
                idTextBox2.BackColor = Color.Salmon;
                modSaveButton.Enabled = false;
                MessageBox.Show("Invalid inventory entry, interger values accepted.", "Invalid Inventory");
            }
            else
            {
                idTextBox2.BackColor = Color.White;
            }
            if (nameTextBox2.BackColor == Color.White &&
            inventoryTextBox2.BackColor == Color.White &&
            pcTextBox2.BackColor == Color.White &&
            maxTextBox2.BackColor == Color.White &&
            minTextBox2.BackColor == Color.White &&
            machineTextBox2.BackColor == Color.White)
            {
                modSaveButton.Enabled = true;
            }
            else
            {
                modSaveButton.Enabled = false;
            }
        }

        private void modSaveButton_Click(object sender, EventArgs e)
        {
            if (inHouseRadio2.Checked == true)
            {
                int PartID = (int.Parse(idTextBox2.Text));
                string Name = nameTextBox2.Text;
                decimal Price = (decimal.Parse(pcTextBox2.Text));
                int InStock = (int.Parse(inventoryTextBox2.Text));
                int Max = (int.Parse(maxTextBox2.Text));
                int Min = (int.Parse(minTextBox2.Text));
                int MachineID = (int.Parse(machineTextBox2.Text));
                InHousePart x = new InHousePart(PartID, Name, Price, InStock, Min, Max, MachineID);
                Inventory.AllParts.Add(x);
            }
            else
            {
                int PartID = (int.Parse(idTextBox2.Text));
                string Name = nameTextBox2.Text;
                decimal Price = (decimal.Parse(pcTextBox2.Text));
                int InStock = (int.Parse(inventoryTextBox2.Text));
                int Max = (int.Parse(maxTextBox2.Text));
                int Min = (int.Parse(minTextBox2.Text));
                string CompanyName = machineTextBox2.Text;
                OSPart x = new OSPart(PartID, Name, Price, InStock, Min, Max, CompanyName);
                Inventory.AllParts.Add(x);
            }

            Inventory.AllParts.Remove(mainForm.currentSelectedPart);

            this.Hide();
            mainForm.Show();
        }

    }
}
