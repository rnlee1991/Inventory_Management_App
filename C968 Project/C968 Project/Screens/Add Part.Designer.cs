
namespace C968_Project
{
    partial class AddPartForm
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
            this.partLabel = new System.Windows.Forms.Label();
            this.inHouseRadio1 = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio2 = new System.Windows.Forms.RadioButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.inventoryLabel1 = new System.Windows.Forms.Label();
            this.inventoryTextBox1 = new System.Windows.Forms.TextBox();
            this.pcLabel1 = new System.Windows.Forms.Label();
            this.pcTextBox1 = new System.Windows.Forms.TextBox();
            this.maxLabel1 = new System.Windows.Forms.Label();
            this.maxTextBox1 = new System.Windows.Forms.TextBox();
            this.minLabel1 = new System.Windows.Forms.Label();
            this.minTextBox1 = new System.Windows.Forms.TextBox();
            this.machineLabel1 = new System.Windows.Forms.Label();
            this.machineTextBox1 = new System.Windows.Forms.TextBox();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partLabel.Location = new System.Drawing.Point(-2, -2);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(69, 21);
            this.partLabel.TabIndex = 0;
            this.partLabel.Text = "Add Part";
            // 
            // inHouseRadio1
            // 
            this.inHouseRadio1.AutoSize = true;
            this.inHouseRadio1.Location = new System.Drawing.Point(95, 1);
            this.inHouseRadio1.Name = "inHouseRadio1";
            this.inHouseRadio1.Size = new System.Drawing.Size(74, 19);
            this.inHouseRadio1.TabIndex = 1;
            this.inHouseRadio1.TabStop = true;
            this.inHouseRadio1.Text = "In-House";
            this.inHouseRadio1.UseVisualStyleBackColor = true;
            this.inHouseRadio1.CheckedChanged += new System.EventHandler(this.inHouseRadio1_CheckedChanged);
            // 
            // outsourcedRadio2
            // 
            this.outsourcedRadio2.AutoSize = true;
            this.outsourcedRadio2.Location = new System.Drawing.Point(210, 1);
            this.outsourcedRadio2.Name = "outsourcedRadio2";
            this.outsourcedRadio2.Size = new System.Drawing.Size(87, 19);
            this.outsourcedRadio2.TabIndex = 2;
            this.outsourcedRadio2.TabStop = true;
            this.outsourcedRadio2.Text = "Outsourced";
            this.outsourcedRadio2.UseVisualStyleBackColor = true;
            this.outsourcedRadio2.CheckedChanged += new System.EventHandler(this.outsourcedRadio2_CheckedChanged);
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Location = new System.Drawing.Point(95, 67);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(18, 15);
            this.idLabel1.TabIndex = 3;
            this.idLabel1.Text = "ID";
            // 
            // idTextBox1
            // 
            this.idTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.idTextBox1.Location = new System.Drawing.Point(135, 64);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 23);
            this.idTextBox1.TabIndex = 4;
            this.idTextBox1.TextChanged += new System.EventHandler(this.idTextBox1_TextChanged);
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(75, 108);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(39, 15);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "Name";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.nameTextBox1.Location = new System.Drawing.Point(135, 100);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox1.TabIndex = 6;
            this.nameTextBox1.TextChanged += new System.EventHandler(this.nameTextBox1_TextChanged);
            // 
            // inventoryLabel1
            // 
            this.inventoryLabel1.AutoSize = true;
            this.inventoryLabel1.Location = new System.Drawing.Point(56, 140);
            this.inventoryLabel1.Name = "inventoryLabel1";
            this.inventoryLabel1.Size = new System.Drawing.Size(57, 15);
            this.inventoryLabel1.TabIndex = 7;
            this.inventoryLabel1.Text = "Inventory";
            // 
            // inventoryTextBox1
            // 
            this.inventoryTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.inventoryTextBox1.Location = new System.Drawing.Point(135, 137);
            this.inventoryTextBox1.Name = "inventoryTextBox1";
            this.inventoryTextBox1.Size = new System.Drawing.Size(100, 23);
            this.inventoryTextBox1.TabIndex = 8;
            this.inventoryTextBox1.TextChanged += new System.EventHandler(this.inventoryTextBox1_TextChanged);
            // 
            // pcLabel1
            // 
            this.pcLabel1.AutoSize = true;
            this.pcLabel1.Location = new System.Drawing.Point(52, 176);
            this.pcLabel1.Name = "pcLabel1";
            this.pcLabel1.Size = new System.Drawing.Size(62, 15);
            this.pcLabel1.TabIndex = 9;
            this.pcLabel1.Text = "Price/Cost";
            // 
            // pcTextBox1
            // 
            this.pcTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.pcTextBox1.Location = new System.Drawing.Point(135, 173);
            this.pcTextBox1.Name = "pcTextBox1";
            this.pcTextBox1.Size = new System.Drawing.Size(100, 23);
            this.pcTextBox1.TabIndex = 10;
            this.pcTextBox1.TextChanged += new System.EventHandler(this.pcTextBox1_TextChanged);
            // 
            // maxLabel1
            // 
            this.maxLabel1.AutoSize = true;
            this.maxLabel1.Location = new System.Drawing.Point(75, 217);
            this.maxLabel1.Name = "maxLabel1";
            this.maxLabel1.Size = new System.Drawing.Size(30, 15);
            this.maxLabel1.TabIndex = 11;
            this.maxLabel1.Text = "Max";
            // 
            // maxTextBox1
            // 
            this.maxTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.maxTextBox1.Location = new System.Drawing.Point(135, 209);
            this.maxTextBox1.Name = "maxTextBox1";
            this.maxTextBox1.Size = new System.Drawing.Size(47, 23);
            this.maxTextBox1.TabIndex = 12;
            this.maxTextBox1.TextChanged += new System.EventHandler(this.maxTextBox1_TextChanged);
            // 
            // minLabel1
            // 
            this.minLabel1.AutoSize = true;
            this.minLabel1.Location = new System.Drawing.Point(210, 217);
            this.minLabel1.Name = "minLabel1";
            this.minLabel1.Size = new System.Drawing.Size(28, 15);
            this.minLabel1.TabIndex = 13;
            this.minLabel1.Text = "Min";
            // 
            // minTextBox1
            // 
            this.minTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.minTextBox1.Location = new System.Drawing.Point(259, 209);
            this.minTextBox1.Name = "minTextBox1";
            this.minTextBox1.Size = new System.Drawing.Size(48, 23);
            this.minTextBox1.TabIndex = 14;
            this.minTextBox1.TextChanged += new System.EventHandler(this.minTextBox1_TextChanged);
            // 
            // machineLabel1
            // 
            this.machineLabel1.AutoSize = true;
            this.machineLabel1.Location = new System.Drawing.Point(38, 250);
            this.machineLabel1.Name = "machineLabel1";
            this.machineLabel1.Size = new System.Drawing.Size(67, 15);
            this.machineLabel1.TabIndex = 15;
            this.machineLabel1.Text = "Machine ID";
            // 
            // machineTextBox1
            // 
            this.machineTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.machineTextBox1.Location = new System.Drawing.Point(135, 247);
            this.machineTextBox1.Name = "machineTextBox1";
            this.machineTextBox1.Size = new System.Drawing.Size(100, 23);
            this.machineTextBox1.TabIndex = 16;
            this.machineTextBox1.TextChanged += new System.EventHandler(this.machineTextBox1_TextChanged);
            // 
            // addSaveButton
            // 
            this.addSaveButton.Location = new System.Drawing.Point(160, 303);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addSaveButton.TabIndex = 17;
            this.addSaveButton.Text = "Save";
            this.addSaveButton.UseVisualStyleBackColor = true;
            this.addSaveButton.Click += new System.EventHandler(this.addSaveButton_Click);
            // 
            // addCancelButton
            // 
            this.addCancelButton.Location = new System.Drawing.Point(259, 303);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addCancelButton.TabIndex = 18;
            this.addCancelButton.Text = "Cancel";
            this.addCancelButton.UseVisualStyleBackColor = true;
            this.addCancelButton.Click += new System.EventHandler(this.addCancelButton_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 345);
            this.Controls.Add(this.addCancelButton);
            this.Controls.Add(this.addSaveButton);
            this.Controls.Add(this.machineTextBox1);
            this.Controls.Add(this.machineLabel1);
            this.Controls.Add(this.minTextBox1);
            this.Controls.Add(this.minLabel1);
            this.Controls.Add(this.maxTextBox1);
            this.Controls.Add(this.maxLabel1);
            this.Controls.Add(this.pcTextBox1);
            this.Controls.Add(this.pcLabel1);
            this.Controls.Add(this.inventoryTextBox1);
            this.Controls.Add(this.inventoryLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.outsourcedRadio2);
            this.Controls.Add(this.inHouseRadio1);
            this.Controls.Add(this.partLabel);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.RadioButton inHouseRadio1;
        private System.Windows.Forms.RadioButton outsourcedRadio2;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label inventoryLabel1;
        private System.Windows.Forms.TextBox inventoryTextBox1;
        private System.Windows.Forms.Label pcLabel1;
        private System.Windows.Forms.TextBox pcTextBox1;
        private System.Windows.Forms.Label maxLabel1;
        private System.Windows.Forms.TextBox maxTextBox1;
        private System.Windows.Forms.Label minLabel1;
        private System.Windows.Forms.TextBox minTextBox1;
        private System.Windows.Forms.Label machineLabel1;
        private System.Windows.Forms.TextBox machineTextBox1;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.Button addCancelButton;
    }
}