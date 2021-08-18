
namespace C968_Project
{
    partial class ModProdForm
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
            this.modProdLabel = new System.Windows.Forms.Label();
            this.idLabel3 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.inventoryLabel3 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel3 = new System.Windows.Forms.Label();
            this.minLabel3 = new System.Windows.Forms.Label();
            this.minTextBox3 = new System.Windows.Forms.TextBox();
            this.maxTextBox3 = new System.Windows.Forms.TextBox();
            this.searchButton3 = new System.Windows.Forms.Button();
            this.modProdSearchBox = new System.Windows.Forms.TextBox();
            this.modProdAllParts = new System.Windows.Forms.DataGridView();
            this.modProdAssocParts = new System.Windows.Forms.DataGridView();
            this.addPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modProdSaveButton = new System.Windows.Forms.Button();
            this.modProdCancelButton = new System.Windows.Forms.Button();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            this.idTextBox3 = new System.Windows.Forms.TextBox();
            this.nameTextBox3 = new System.Windows.Forms.TextBox();
            this.inventoryTextBox3 = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.modProdAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProdAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // modProdLabel
            // 
            this.modProdLabel.AutoSize = true;
            this.modProdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modProdLabel.Location = new System.Drawing.Point(12, 9);
            this.modProdLabel.Name = "modProdLabel";
            this.modProdLabel.Size = new System.Drawing.Size(142, 25);
            this.modProdLabel.TabIndex = 0;
            this.modProdLabel.Text = "Modify Product";
            // 
            // idLabel3
            // 
            this.idLabel3.AutoSize = true;
            this.idLabel3.Location = new System.Drawing.Point(30, 81);
            this.idLabel3.Name = "idLabel3";
            this.idLabel3.Size = new System.Drawing.Size(21, 15);
            this.idLabel3.TabIndex = 1;
            this.idLabel3.Text = "ID ";
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Location = new System.Drawing.Point(12, 128);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(39, 15);
            this.nameLabel3.TabIndex = 2;
            this.nameLabel3.Text = "Name";
            // 
            // inventoryLabel3
            // 
            this.inventoryLabel3.AutoSize = true;
            this.inventoryLabel3.Location = new System.Drawing.Point(12, 176);
            this.inventoryLabel3.Name = "inventoryLabel3";
            this.inventoryLabel3.Size = new System.Drawing.Size(57, 15);
            this.inventoryLabel3.TabIndex = 3;
            this.inventoryLabel3.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 226);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel3
            // 
            this.maxLabel3.AutoSize = true;
            this.maxLabel3.Location = new System.Drawing.Point(13, 277);
            this.maxLabel3.Name = "maxLabel3";
            this.maxLabel3.Size = new System.Drawing.Size(30, 15);
            this.maxLabel3.TabIndex = 5;
            this.maxLabel3.Text = "Max";
            // 
            // minLabel3
            // 
            this.minLabel3.AutoSize = true;
            this.minLabel3.Location = new System.Drawing.Point(116, 277);
            this.minLabel3.Name = "minLabel3";
            this.minLabel3.Size = new System.Drawing.Size(28, 15);
            this.minLabel3.TabIndex = 6;
            this.minLabel3.Text = "Min";
            // 
            // minTextBox3
            // 
            this.minTextBox3.Location = new System.Drawing.Point(150, 274);
            this.minTextBox3.Name = "minTextBox3";
            this.minTextBox3.Size = new System.Drawing.Size(52, 23);
            this.minTextBox3.TabIndex = 7;
            this.minTextBox3.TextChanged += new System.EventHandler(this.minTextBox3_TextChanged);
            // 
            // maxTextBox3
            // 
            this.maxTextBox3.Location = new System.Drawing.Point(49, 274);
            this.maxTextBox3.Name = "maxTextBox3";
            this.maxTextBox3.Size = new System.Drawing.Size(51, 23);
            this.maxTextBox3.TabIndex = 8;
            this.maxTextBox3.TextChanged += new System.EventHandler(this.maxTextBox3_TextChanged);
            // 
            // searchButton3
            // 
            this.searchButton3.Location = new System.Drawing.Point(486, 8);
            this.searchButton3.Name = "searchButton3";
            this.searchButton3.Size = new System.Drawing.Size(75, 23);
            this.searchButton3.TabIndex = 9;
            this.searchButton3.Text = "Search";
            this.searchButton3.UseVisualStyleBackColor = true;
            this.searchButton3.Click += new System.EventHandler(this.searchButton3_Click);
            // 
            // modProdSearchBox
            // 
            this.modProdSearchBox.Location = new System.Drawing.Point(567, 8);
            this.modProdSearchBox.Name = "modProdSearchBox";
            this.modProdSearchBox.Size = new System.Drawing.Size(149, 23);
            this.modProdSearchBox.TabIndex = 10;
            this.modProdSearchBox.TextChanged += new System.EventHandler(this.modProdSearchBox_TextChanged);
            // 
            // modProdAllParts
            // 
            this.modProdAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProdAllParts.Location = new System.Drawing.Point(249, 37);
            this.modProdAllParts.Name = "modProdAllParts";
            this.modProdAllParts.RowTemplate.Height = 25;
            this.modProdAllParts.Size = new System.Drawing.Size(467, 163);
            this.modProdAllParts.TabIndex = 11;
            this.modProdAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modProdAllParts_CellClick);
            // 
            // modProdAssocParts
            // 
            this.modProdAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProdAssocParts.Location = new System.Drawing.Point(249, 249);
            this.modProdAssocParts.Name = "modProdAssocParts";
            this.modProdAssocParts.RowTemplate.Height = 25;
            this.modProdAssocParts.Size = new System.Drawing.Size(467, 150);
            this.modProdAssocParts.TabIndex = 12;
            this.modProdAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modProdAssocParts_CellClick);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(722, 168);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 13;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(722, 376);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 14;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // modProdSaveButton
            // 
            this.modProdSaveButton.Location = new System.Drawing.Point(521, 415);
            this.modProdSaveButton.Name = "modProdSaveButton";
            this.modProdSaveButton.Size = new System.Drawing.Size(75, 23);
            this.modProdSaveButton.TabIndex = 15;
            this.modProdSaveButton.Text = "Save";
            this.modProdSaveButton.UseVisualStyleBackColor = true;
            this.modProdSaveButton.Click += new System.EventHandler(this.modProdSaveButton_Click);
            // 
            // modProdCancelButton
            // 
            this.modProdCancelButton.Location = new System.Drawing.Point(602, 415);
            this.modProdCancelButton.Name = "modProdCancelButton";
            this.modProdCancelButton.Size = new System.Drawing.Size(75, 23);
            this.modProdCancelButton.TabIndex = 16;
            this.modProdCancelButton.Text = "Cancel";
            this.modProdCancelButton.UseVisualStyleBackColor = true;
            this.modProdCancelButton.Click += new System.EventHandler(this.modProdCancelButton_Click);
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Location = new System.Drawing.Point(249, 16);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(50, 15);
            this.allPartsLabel.TabIndex = 17;
            this.allPartsLabel.Text = "All Parts";
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Location = new System.Drawing.Point(249, 226);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(186, 15);
            this.assocPartsLabel.TabIndex = 18;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // idTextBox3
            // 
            this.idTextBox3.Location = new System.Drawing.Point(67, 78);
            this.idTextBox3.Name = "idTextBox3";
            this.idTextBox3.Size = new System.Drawing.Size(100, 23);
            this.idTextBox3.TabIndex = 19;
            this.idTextBox3.TextChanged += new System.EventHandler(this.idTextBox3_TextChanged);
            // 
            // nameTextBox3
            // 
            this.nameTextBox3.Location = new System.Drawing.Point(67, 128);
            this.nameTextBox3.Name = "nameTextBox3";
            this.nameTextBox3.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox3.TabIndex = 20;
            this.nameTextBox3.TextChanged += new System.EventHandler(this.nameTextBox3_TextChanged);
            // 
            // inventoryTextBox3
            // 
            this.inventoryTextBox3.Location = new System.Drawing.Point(75, 173);
            this.inventoryTextBox3.Name = "inventoryTextBox3";
            this.inventoryTextBox3.Size = new System.Drawing.Size(100, 23);
            this.inventoryTextBox3.TabIndex = 21;
            this.inventoryTextBox3.TextChanged += new System.EventHandler(this.inventoryTextBox3_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(54, 223);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 22;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // ModProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox3);
            this.Controls.Add(this.nameTextBox3);
            this.Controls.Add(this.idTextBox3);
            this.Controls.Add(this.assocPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.modProdCancelButton);
            this.Controls.Add(this.modProdSaveButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.modProdAssocParts);
            this.Controls.Add(this.modProdAllParts);
            this.Controls.Add(this.modProdSearchBox);
            this.Controls.Add(this.searchButton3);
            this.Controls.Add(this.maxTextBox3);
            this.Controls.Add(this.minTextBox3);
            this.Controls.Add(this.minLabel3);
            this.Controls.Add(this.maxLabel3);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel3);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(this.idLabel3);
            this.Controls.Add(this.modProdLabel);
            this.Name = "ModProdForm";
            this.Text = "Modify Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.modProdAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProdAssocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modProdLabel;
        private System.Windows.Forms.Label idLabel3;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Label inventoryLabel3;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel3;
        private System.Windows.Forms.Label minLabel3;
        private System.Windows.Forms.TextBox minTextBox3;
        private System.Windows.Forms.TextBox maxTextBox3;
        private System.Windows.Forms.Button searchButton3;
        private System.Windows.Forms.TextBox modProdSearchBox;
        private System.Windows.Forms.DataGridView modProdAllParts;
        private System.Windows.Forms.DataGridView modProdAssocParts;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modProdSaveButton;
        private System.Windows.Forms.Button modProdCancelButton;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Label assocPartsLabel;
        private System.Windows.Forms.TextBox idTextBox3;
        private System.Windows.Forms.TextBox nameTextBox3;
        private System.Windows.Forms.TextBox inventoryTextBox3;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}