
namespace C968_Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvManLabel = new System.Windows.Forms.Label();
            this.modifyButton1 = new System.Windows.Forms.Panel();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.modButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.modifyButton2 = new System.Windows.Forms.Button();
            this.addButton2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.modifyButton1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // InvManLabel
            // 
            this.InvManLabel.AutoSize = true;
            this.InvManLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InvManLabel.Location = new System.Drawing.Point(0, 0);
            this.InvManLabel.Name = "InvManLabel";
            this.InvManLabel.Size = new System.Drawing.Size(271, 25);
            this.InvManLabel.TabIndex = 0;
            this.InvManLabel.Text = "Inventory Management System";
            // 
            // modifyButton1
            // 
            this.modifyButton1.Controls.Add(this.deleteButton1);
            this.modifyButton1.Controls.Add(this.modButton1);
            this.modifyButton1.Controls.Add(this.addButton1);
            this.modifyButton1.Controls.Add(this.partsLabel);
            this.modifyButton1.Controls.Add(this.dataGridView1);
            this.modifyButton1.Controls.Add(this.textBox1);
            this.modifyButton1.Controls.Add(this.searchButton1);
            this.modifyButton1.Location = new System.Drawing.Point(0, 55);
            this.modifyButton1.Name = "modifyButton1";
            this.modifyButton1.Size = new System.Drawing.Size(549, 429);
            this.modifyButton1.TabIndex = 1;
            // 
            // deleteButton1
            // 
            this.deleteButton1.Location = new System.Drawing.Point(474, 308);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(75, 23);
            this.deleteButton1.TabIndex = 6;
            this.deleteButton1.Text = "Delete";
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // modButton1
            // 
            this.modButton1.Location = new System.Drawing.Point(396, 308);
            this.modButton1.Name = "modButton1";
            this.modButton1.Size = new System.Drawing.Size(75, 23);
            this.modButton1.TabIndex = 5;
            this.modButton1.Text = "Modify";
            this.modButton1.UseVisualStyleBackColor = true;
            this.modButton1.Click += new System.EventHandler(this.modButton1_Click);
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(315, 308);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(75, 23);
            this.addButton1.TabIndex = 4;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsLabel.Location = new System.Drawing.Point(12, 41);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(40, 20);
            this.partsLabel.TabIndex = 3;
            this.partsLabel.Text = "Parts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(537, 238);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchButton1
            // 
            this.searchButton1.Location = new System.Drawing.Point(196, 0);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(75, 23);
            this.searchButton1.TabIndex = 0;
            this.searchButton1.Text = "Search";
            this.searchButton1.UseVisualStyleBackColor = true;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.productsLabel);
            this.panel1.Controls.Add(this.deleteButton2);
            this.panel1.Controls.Add(this.modifyButton2);
            this.panel1.Controls.Add(this.addButton2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.searchButton2);
            this.panel1.Location = new System.Drawing.Point(593, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 428);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(426, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsLabel.Location = new System.Drawing.Point(0, 40);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(66, 20);
            this.productsLabel.TabIndex = 3;
            this.productsLabel.Text = "Products";
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(426, 307);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(75, 23);
            this.deleteButton2.TabIndex = 5;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // modifyButton2
            // 
            this.modifyButton2.Location = new System.Drawing.Point(344, 307);
            this.modifyButton2.Name = "modifyButton2";
            this.modifyButton2.Size = new System.Drawing.Size(75, 23);
            this.modifyButton2.TabIndex = 4;
            this.modifyButton2.Text = "Modify";
            this.modifyButton2.UseVisualStyleBackColor = true;
            this.modifyButton2.Click += new System.EventHandler(this.modifyButton2_Click);
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(263, 307);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(75, 23);
            this.addButton2.TabIndex = 3;
            this.addButton2.Text = "Add";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(501, 238);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // searchButton2
            // 
            this.searchButton2.Location = new System.Drawing.Point(182, 1);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(75, 23);
            this.searchButton2.TabIndex = 0;
            this.searchButton2.Text = "Search";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modifyButton1);
            this.Controls.Add(this.InvManLabel);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.modifyButton1.ResumeLayout(false);
            this.modifyButton1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvManLabel;
        private System.Windows.Forms.Panel modifyButton1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button modButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button modifyButton2;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.Button exitButton;
    }
}

