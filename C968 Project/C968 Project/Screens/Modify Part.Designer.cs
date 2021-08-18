
namespace C968_Project
{
    partial class ModPartForm
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
            this.modifyLabel = new System.Windows.Forms.Label();
            this.inHouseRadio2 = new System.Windows.Forms.RadioButton();
            this.outSourcedRadio2 = new System.Windows.Forms.RadioButton();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.inventoryLabel2 = new System.Windows.Forms.Label();
            this.pcLabel2 = new System.Windows.Forms.Label();
            this.maxLabel2 = new System.Windows.Forms.Label();
            this.minLabel2 = new System.Windows.Forms.Label();
            this.machineLabel2 = new System.Windows.Forms.Label();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.inventoryTextBox2 = new System.Windows.Forms.TextBox();
            this.pcTextBox2 = new System.Windows.Forms.TextBox();
            this.maxTextBox2 = new System.Windows.Forms.TextBox();
            this.minTextBox2 = new System.Windows.Forms.TextBox();
            this.machineTextBox2 = new System.Windows.Forms.TextBox();
            this.modSaveButton = new System.Windows.Forms.Button();
            this.modCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyLabel
            // 
            this.modifyLabel.AutoSize = true;
            this.modifyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyLabel.Location = new System.Drawing.Point(0, 0);
            this.modifyLabel.Name = "modifyLabel";
            this.modifyLabel.Size = new System.Drawing.Size(90, 21);
            this.modifyLabel.TabIndex = 0;
            this.modifyLabel.Text = "Modify Part";
            // 
            // inHouseRadio2
            // 
            this.inHouseRadio2.AutoSize = true;
            this.inHouseRadio2.Location = new System.Drawing.Point(112, 3);
            this.inHouseRadio2.Name = "inHouseRadio2";
            this.inHouseRadio2.Size = new System.Drawing.Size(74, 19);
            this.inHouseRadio2.TabIndex = 1;
            this.inHouseRadio2.TabStop = true;
            this.inHouseRadio2.Text = "In-House";
            this.inHouseRadio2.UseVisualStyleBackColor = true;
            this.inHouseRadio2.CheckedChanged += new System.EventHandler(this.inHouseRadio2_CheckedChanged);
            // 
            // outSourcedRadio2
            // 
            this.outSourcedRadio2.AutoSize = true;
            this.outSourcedRadio2.Location = new System.Drawing.Point(212, 3);
            this.outSourcedRadio2.Name = "outSourcedRadio2";
            this.outSourcedRadio2.Size = new System.Drawing.Size(87, 19);
            this.outSourcedRadio2.TabIndex = 2;
            this.outSourcedRadio2.TabStop = true;
            this.outSourcedRadio2.Text = "Outsourced";
            this.outSourcedRadio2.UseVisualStyleBackColor = true;
            this.outSourcedRadio2.CheckedChanged += new System.EventHandler(this.outSourcedRadio2_CheckedChanged_1);
            // 
            // idLabel2
            // 
            this.idLabel2.AutoSize = true;
            this.idLabel2.Location = new System.Drawing.Point(112, 47);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(21, 15);
            this.idLabel2.TabIndex = 3;
            this.idLabel2.Text = "ID ";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(94, 82);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(39, 15);
            this.nameLabel2.TabIndex = 4;
            this.nameLabel2.Text = "Name";
            // 
            // inventoryLabel2
            // 
            this.inventoryLabel2.AutoSize = true;
            this.inventoryLabel2.Location = new System.Drawing.Point(76, 117);
            this.inventoryLabel2.Name = "inventoryLabel2";
            this.inventoryLabel2.Size = new System.Drawing.Size(57, 15);
            this.inventoryLabel2.TabIndex = 5;
            this.inventoryLabel2.Text = "Inventory";
            // 
            // pcLabel2
            // 
            this.pcLabel2.AutoSize = true;
            this.pcLabel2.Location = new System.Drawing.Point(71, 154);
            this.pcLabel2.Name = "pcLabel2";
            this.pcLabel2.Size = new System.Drawing.Size(62, 15);
            this.pcLabel2.TabIndex = 6;
            this.pcLabel2.Text = "Price/Cost";
            // 
            // maxLabel2
            // 
            this.maxLabel2.AutoSize = true;
            this.maxLabel2.Location = new System.Drawing.Point(95, 194);
            this.maxLabel2.Name = "maxLabel2";
            this.maxLabel2.Size = new System.Drawing.Size(30, 15);
            this.maxLabel2.TabIndex = 7;
            this.maxLabel2.Text = "Max";
            // 
            // minLabel2
            // 
            this.minLabel2.AutoSize = true;
            this.minLabel2.Location = new System.Drawing.Point(198, 194);
            this.minLabel2.Name = "minLabel2";
            this.minLabel2.Size = new System.Drawing.Size(28, 15);
            this.minLabel2.TabIndex = 8;
            this.minLabel2.Text = "Min";
            // 
            // machineLabel2
            // 
            this.machineLabel2.AutoSize = true;
            this.machineLabel2.Location = new System.Drawing.Point(58, 239);
            this.machineLabel2.Name = "machineLabel2";
            this.machineLabel2.Size = new System.Drawing.Size(67, 15);
            this.machineLabel2.TabIndex = 9;
            this.machineLabel2.Text = "Machine ID";
            // 
            // idTextBox2
            // 
            this.idTextBox2.Enabled = false;
            this.idTextBox2.Location = new System.Drawing.Point(152, 44);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.ReadOnly = true;
            this.idTextBox2.Size = new System.Drawing.Size(100, 23);
            this.idTextBox2.TabIndex = 10;
            this.idTextBox2.TextChanged += new System.EventHandler(this.idTextBox2_TextChanged);
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(152, 79);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox2.TabIndex = 11;
            this.nameTextBox2.TextChanged += new System.EventHandler(this.nameTextBox2_TextChanged);
            // 
            // inventoryTextBox2
            // 
            this.inventoryTextBox2.Location = new System.Drawing.Point(152, 114);
            this.inventoryTextBox2.Name = "inventoryTextBox2";
            this.inventoryTextBox2.Size = new System.Drawing.Size(100, 23);
            this.inventoryTextBox2.TabIndex = 12;
            this.inventoryTextBox2.TextChanged += new System.EventHandler(this.inventoryTextBox2_TextChanged);
            // 
            // pcTextBox2
            // 
            this.pcTextBox2.Location = new System.Drawing.Point(152, 151);
            this.pcTextBox2.Name = "pcTextBox2";
            this.pcTextBox2.Size = new System.Drawing.Size(100, 23);
            this.pcTextBox2.TabIndex = 13;
            this.pcTextBox2.TextChanged += new System.EventHandler(this.pcTextBox2_TextChanged);
            // 
            // maxTextBox2
            // 
            this.maxTextBox2.Location = new System.Drawing.Point(131, 191);
            this.maxTextBox2.Name = "maxTextBox2";
            this.maxTextBox2.Size = new System.Drawing.Size(48, 23);
            this.maxTextBox2.TabIndex = 14;
            this.maxTextBox2.TextChanged += new System.EventHandler(this.maxTextBox2_TextChanged);
            // 
            // minTextBox2
            // 
            this.minTextBox2.Location = new System.Drawing.Point(232, 191);
            this.minTextBox2.Name = "minTextBox2";
            this.minTextBox2.Size = new System.Drawing.Size(51, 23);
            this.minTextBox2.TabIndex = 15;
            this.minTextBox2.TextChanged += new System.EventHandler(this.minTextBox2_TextChanged);
            // 
            // machineTextBox2
            // 
            this.machineTextBox2.Location = new System.Drawing.Point(152, 236);
            this.machineTextBox2.Name = "machineTextBox2";
            this.machineTextBox2.Size = new System.Drawing.Size(100, 23);
            this.machineTextBox2.TabIndex = 16;
            this.machineTextBox2.TextChanged += new System.EventHandler(this.machineTextBox2_TextChanged);
            // 
            // modSaveButton
            // 
            this.modSaveButton.Location = new System.Drawing.Point(177, 295);
            this.modSaveButton.Name = "modSaveButton";
            this.modSaveButton.Size = new System.Drawing.Size(75, 23);
            this.modSaveButton.TabIndex = 17;
            this.modSaveButton.Text = "Save";
            this.modSaveButton.UseVisualStyleBackColor = true;
            this.modSaveButton.Click += new System.EventHandler(this.modSaveButton_Click);
            // 
            // modCancelButton
            // 
            this.modCancelButton.Location = new System.Drawing.Point(258, 295);
            this.modCancelButton.Name = "modCancelButton";
            this.modCancelButton.Size = new System.Drawing.Size(75, 23);
            this.modCancelButton.TabIndex = 18;
            this.modCancelButton.Text = "Cancel";
            this.modCancelButton.UseVisualStyleBackColor = true;
            this.modCancelButton.Click += new System.EventHandler(this.modCancelButton_Click);
            // 
            // ModPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 334);
            this.Controls.Add(this.modCancelButton);
            this.Controls.Add(this.modSaveButton);
            this.Controls.Add(this.machineTextBox2);
            this.Controls.Add(this.minTextBox2);
            this.Controls.Add(this.maxTextBox2);
            this.Controls.Add(this.pcTextBox2);
            this.Controls.Add(this.inventoryTextBox2);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(this.machineLabel2);
            this.Controls.Add(this.minLabel2);
            this.Controls.Add(this.maxLabel2);
            this.Controls.Add(this.pcLabel2);
            this.Controls.Add(this.inventoryLabel2);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.idLabel2);
            this.Controls.Add(this.outSourcedRadio2);
            this.Controls.Add(this.inHouseRadio2);
            this.Controls.Add(this.modifyLabel);
            this.Name = "ModPartForm";
            this.Text = "Modify Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyLabel;
        private System.Windows.Forms.RadioButton inHouseRadio2;
        private System.Windows.Forms.RadioButton outSourcedRadio2;
        private System.Windows.Forms.Label idLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label inventoryLabel2;
        private System.Windows.Forms.Label pcLabel2;
        private System.Windows.Forms.Label maxLabel2;
        private System.Windows.Forms.Label minLabel2;
        private System.Windows.Forms.Label machineLabel2;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.TextBox inventoryTextBox2;
        private System.Windows.Forms.TextBox pcTextBox2;
        private System.Windows.Forms.TextBox maxTextBox2;
        private System.Windows.Forms.TextBox minTextBox2;
        private System.Windows.Forms.TextBox machineTextBox2;
        private System.Windows.Forms.Button modSaveButton;
        private System.Windows.Forms.Button modCancelButton;
    }
}