
namespace C968_Project
{
    partial class AddProdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priceTextBox2 = new System.Windows.Forms.TextBox();
            this.inventoryTextBox4 = new System.Windows.Forms.TextBox();
            this.nameTextBox4 = new System.Windows.Forms.TextBox();
            this.idTextBox4 = new System.Windows.Forms.TextBox();
            this.assocPartsLabel2 = new System.Windows.Forms.Label();
            this.allPartsLabel2 = new System.Windows.Forms.Label();
            this.addProdCancelButton = new System.Windows.Forms.Button();
            this.addProdSaveButton = new System.Windows.Forms.Button();
            this.deletePartButton2 = new System.Windows.Forms.Button();
            this.addPartButton2 = new System.Windows.Forms.Button();
            this.addProdAssocParts = new System.Windows.Forms.DataGridView();
            this.addProdAllParts = new System.Windows.Forms.DataGridView();
            this.addProdSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton4 = new System.Windows.Forms.Button();
            this.maxTextBox4 = new System.Windows.Forms.TextBox();
            this.minTextBox4 = new System.Windows.Forms.TextBox();
            this.minLabel3 = new System.Windows.Forms.Label();
            this.maxLabel4 = new System.Windows.Forms.Label();
            this.priceLabel2 = new System.Windows.Forms.Label();
            this.inventoryLabel4 = new System.Windows.Forms.Label();
            this.nameLabel4 = new System.Windows.Forms.Label();
            this.idLabel4 = new System.Windows.Forms.Label();
            this.addProdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addProdAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProdAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTextBox2
            // 
            this.priceTextBox2.Location = new System.Drawing.Point(50, 225);
            this.priceTextBox2.Name = "priceTextBox2";
            this.priceTextBox2.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox2.TabIndex = 45;
            this.priceTextBox2.TextChanged += new System.EventHandler(this.priceTextBox2_TextChanged);
            // 
            // inventoryTextBox4
            // 
            this.inventoryTextBox4.Location = new System.Drawing.Point(71, 175);
            this.inventoryTextBox4.Name = "inventoryTextBox4";
            this.inventoryTextBox4.Size = new System.Drawing.Size(100, 23);
            this.inventoryTextBox4.TabIndex = 44;
            this.inventoryTextBox4.TextChanged += new System.EventHandler(this.inventoryTextBox4_TextChanged);
            // 
            // nameTextBox4
            // 
            this.nameTextBox4.Location = new System.Drawing.Point(63, 130);
            this.nameTextBox4.Name = "nameTextBox4";
            this.nameTextBox4.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox4.TabIndex = 43;
            this.nameTextBox4.TextChanged += new System.EventHandler(this.nameTextBox4_TextChanged);
            // 
            // idTextBox4
            // 
            this.idTextBox4.Location = new System.Drawing.Point(63, 80);
            this.idTextBox4.Name = "idTextBox4";
            this.idTextBox4.Size = new System.Drawing.Size(100, 23);
            this.idTextBox4.TabIndex = 42;
            this.idTextBox4.TextChanged += new System.EventHandler(this.idTextBox4_TextChanged);
            // 
            // assocPartsLabel2
            // 
            this.assocPartsLabel2.AutoSize = true;
            this.assocPartsLabel2.Location = new System.Drawing.Point(245, 228);
            this.assocPartsLabel2.Name = "assocPartsLabel2";
            this.assocPartsLabel2.Size = new System.Drawing.Size(186, 15);
            this.assocPartsLabel2.TabIndex = 41;
            this.assocPartsLabel2.Text = "Parts Associated with this Product";
            // 
            // allPartsLabel2
            // 
            this.allPartsLabel2.AutoSize = true;
            this.allPartsLabel2.Location = new System.Drawing.Point(245, 18);
            this.allPartsLabel2.Name = "allPartsLabel2";
            this.allPartsLabel2.Size = new System.Drawing.Size(50, 15);
            this.allPartsLabel2.TabIndex = 40;
            this.allPartsLabel2.Text = "All Parts";
            // 
            // addProdCancelButton
            // 
            this.addProdCancelButton.Location = new System.Drawing.Point(605, 415);
            this.addProdCancelButton.Name = "addProdCancelButton";
            this.addProdCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addProdCancelButton.TabIndex = 39;
            this.addProdCancelButton.Text = "Cancel";
            this.addProdCancelButton.UseVisualStyleBackColor = true;
            this.addProdCancelButton.Click += new System.EventHandler(this.addProdCancelButton_Click);
            // 
            // addProdSaveButton
            // 
            this.addProdSaveButton.Location = new System.Drawing.Point(524, 415);
            this.addProdSaveButton.Name = "addProdSaveButton";
            this.addProdSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProdSaveButton.TabIndex = 38;
            this.addProdSaveButton.Text = "Save";
            this.addProdSaveButton.UseVisualStyleBackColor = true;
            this.addProdSaveButton.Click += new System.EventHandler(this.addProdSaveButton_Click);
            // 
            // deletePartButton2
            // 
            this.deletePartButton2.Location = new System.Drawing.Point(718, 378);
            this.deletePartButton2.Name = "deletePartButton2";
            this.deletePartButton2.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton2.TabIndex = 37;
            this.deletePartButton2.Text = "Delete";
            this.deletePartButton2.UseVisualStyleBackColor = true;
            this.deletePartButton2.Click += new System.EventHandler(this.deletePartButton2_Click);
            // 
            // addPartButton2
            // 
            this.addPartButton2.Location = new System.Drawing.Point(718, 170);
            this.addPartButton2.Name = "addPartButton2";
            this.addPartButton2.Size = new System.Drawing.Size(75, 23);
            this.addPartButton2.TabIndex = 36;
            this.addPartButton2.Text = "Add";
            this.addPartButton2.UseVisualStyleBackColor = true;
            this.addPartButton2.Click += new System.EventHandler(this.addPartButton2_Click);
            // 
            // addProdAssocParts
            // 
            this.addProdAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProdAssocParts.Location = new System.Drawing.Point(245, 251);
            this.addProdAssocParts.Name = "addProdAssocParts";
            this.addProdAssocParts.RowTemplate.Height = 25;
            this.addProdAssocParts.Size = new System.Drawing.Size(467, 150);
            this.addProdAssocParts.TabIndex = 35;
            this.addProdAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProdAssocParts_CellClick);
            // 
            // addProdAllParts
            // 
            this.addProdAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProdAllParts.Location = new System.Drawing.Point(245, 39);
            this.addProdAllParts.Name = "addProdAllParts";
            this.addProdAllParts.RowTemplate.Height = 25;
            this.addProdAllParts.Size = new System.Drawing.Size(467, 163);
            this.addProdAllParts.TabIndex = 34;
            this.addProdAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProdAllParts_CellClick);
            // 
            // addProdSearchBox
            // 
            this.addProdSearchBox.Location = new System.Drawing.Point(563, 10);
            this.addProdSearchBox.Name = "addProdSearchBox";
            this.addProdSearchBox.Size = new System.Drawing.Size(149, 23);
            this.addProdSearchBox.TabIndex = 33;
            this.addProdSearchBox.TextChanged += new System.EventHandler(this.addProdSearchBox_TextChanged);
            // 
            // searchButton4
            // 
            this.searchButton4.Location = new System.Drawing.Point(482, 10);
            this.searchButton4.Name = "searchButton4";
            this.searchButton4.Size = new System.Drawing.Size(75, 23);
            this.searchButton4.TabIndex = 32;
            this.searchButton4.Text = "Search";
            this.searchButton4.UseVisualStyleBackColor = true;
            this.searchButton4.Click += new System.EventHandler(this.searchButton4_Click);
            // 
            // maxTextBox4
            // 
            this.maxTextBox4.Location = new System.Drawing.Point(45, 276);
            this.maxTextBox4.Name = "maxTextBox4";
            this.maxTextBox4.Size = new System.Drawing.Size(51, 23);
            this.maxTextBox4.TabIndex = 31;
            this.maxTextBox4.TextChanged += new System.EventHandler(this.maxTextBox4_TextChanged);
            // 
            // minTextBox4
            // 
            this.minTextBox4.Location = new System.Drawing.Point(146, 276);
            this.minTextBox4.Name = "minTextBox4";
            this.minTextBox4.Size = new System.Drawing.Size(52, 23);
            this.minTextBox4.TabIndex = 30;
            this.minTextBox4.TextChanged += new System.EventHandler(this.minTextBox4_TextChanged);
            // 
            // minLabel3
            // 
            this.minLabel3.AutoSize = true;
            this.minLabel3.Location = new System.Drawing.Point(112, 279);
            this.minLabel3.Name = "minLabel3";
            this.minLabel3.Size = new System.Drawing.Size(28, 15);
            this.minLabel3.TabIndex = 29;
            this.minLabel3.Text = "Min";
            // 
            // maxLabel4
            // 
            this.maxLabel4.AutoSize = true;
            this.maxLabel4.Location = new System.Drawing.Point(9, 279);
            this.maxLabel4.Name = "maxLabel4";
            this.maxLabel4.Size = new System.Drawing.Size(30, 15);
            this.maxLabel4.TabIndex = 28;
            this.maxLabel4.Text = "Max";
            // 
            // priceLabel2
            // 
            this.priceLabel2.AutoSize = true;
            this.priceLabel2.Location = new System.Drawing.Point(8, 228);
            this.priceLabel2.Name = "priceLabel2";
            this.priceLabel2.Size = new System.Drawing.Size(33, 15);
            this.priceLabel2.TabIndex = 27;
            this.priceLabel2.Text = "Price";
            // 
            // inventoryLabel4
            // 
            this.inventoryLabel4.AutoSize = true;
            this.inventoryLabel4.Location = new System.Drawing.Point(8, 178);
            this.inventoryLabel4.Name = "inventoryLabel4";
            this.inventoryLabel4.Size = new System.Drawing.Size(57, 15);
            this.inventoryLabel4.TabIndex = 26;
            this.inventoryLabel4.Text = "Inventory";
            // 
            // nameLabel4
            // 
            this.nameLabel4.AutoSize = true;
            this.nameLabel4.Location = new System.Drawing.Point(8, 130);
            this.nameLabel4.Name = "nameLabel4";
            this.nameLabel4.Size = new System.Drawing.Size(39, 15);
            this.nameLabel4.TabIndex = 25;
            this.nameLabel4.Text = "Name";
            // 
            // idLabel4
            // 
            this.idLabel4.AutoSize = true;
            this.idLabel4.Location = new System.Drawing.Point(26, 83);
            this.idLabel4.Name = "idLabel4";
            this.idLabel4.Size = new System.Drawing.Size(21, 15);
            this.idLabel4.TabIndex = 24;
            this.idLabel4.Text = "ID ";
            // 
            // addProdLabel
            // 
            this.addProdLabel.AutoSize = true;
            this.addProdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProdLabel.Location = new System.Drawing.Point(8, 11);
            this.addProdLabel.Name = "addProdLabel";
            this.addProdLabel.Size = new System.Drawing.Size(117, 25);
            this.addProdLabel.TabIndex = 23;
            this.addProdLabel.Text = "Add Product";
            // 
            // AddProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceTextBox2);
            this.Controls.Add(this.inventoryTextBox4);
            this.Controls.Add(this.nameTextBox4);
            this.Controls.Add(this.idTextBox4);
            this.Controls.Add(this.assocPartsLabel2);
            this.Controls.Add(this.allPartsLabel2);
            this.Controls.Add(this.addProdCancelButton);
            this.Controls.Add(this.addProdSaveButton);
            this.Controls.Add(this.deletePartButton2);
            this.Controls.Add(this.addPartButton2);
            this.Controls.Add(this.addProdAssocParts);
            this.Controls.Add(this.addProdAllParts);
            this.Controls.Add(this.addProdSearchBox);
            this.Controls.Add(this.searchButton4);
            this.Controls.Add(this.maxTextBox4);
            this.Controls.Add(this.minTextBox4);
            this.Controls.Add(this.minLabel3);
            this.Controls.Add(this.maxLabel4);
            this.Controls.Add(this.priceLabel2);
            this.Controls.Add(this.inventoryLabel4);
            this.Controls.Add(this.nameLabel4);
            this.Controls.Add(this.idLabel4);
            this.Controls.Add(this.addProdLabel);
            this.Name = "AddProdForm";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.addProdAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProdAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox2;
        private System.Windows.Forms.TextBox inventoryTextBox4;
        private System.Windows.Forms.TextBox nameTextBox4;
        private System.Windows.Forms.TextBox idTextBox4;
        private System.Windows.Forms.Label assocPartsLabel2;
        private System.Windows.Forms.Label allPartsLabel2;
        private System.Windows.Forms.Button addProdCancelButton;
        private System.Windows.Forms.Button addProdSaveButton;
        private System.Windows.Forms.Button deletePartButton2;
        private System.Windows.Forms.Button addPartButton2;
        private System.Windows.Forms.DataGridView addProdAssocParts;
        private System.Windows.Forms.DataGridView addProdAllParts;
        private System.Windows.Forms.TextBox addProdSearchBox;
        private System.Windows.Forms.Button searchButton4;
        private System.Windows.Forms.TextBox maxTextBox4;
        private System.Windows.Forms.TextBox minTextBox4;
        private System.Windows.Forms.Label minLabel3;
        private System.Windows.Forms.Label maxLabel4;
        private System.Windows.Forms.Label priceLabel2;
        private System.Windows.Forms.Label inventoryLabel4;
        private System.Windows.Forms.Label nameLabel4;
        private System.Windows.Forms.Label idLabel4;
        private System.Windows.Forms.Label addProdLabel;
    }
}