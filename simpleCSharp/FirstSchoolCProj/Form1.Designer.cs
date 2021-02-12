namespace FirstSchoolCProj
{
    partial class Form1
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchParts = new System.Windows.Forms.TextBox();
            this.buttonSearchParts = new System.Windows.Forms.Button();
            this.labelParts = new System.Windows.Forms.Label();
            this.buttonDeleteParts = new System.Windows.Forms.Button();
            this.buttonModifyParts = new System.Windows.Forms.Button();
            this.buttonAddParts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteProducts = new System.Windows.Forms.Button();
            this.dataGridViewProductsMain = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProducts = new System.Windows.Forms.Label();
            this.buttonModifyProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProducts = new System.Windows.Forms.TextBox();
            this.buttonSearchProducts = new System.Windows.Forms.Button();
            this.labelInventoryManagement = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(951, 366);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 35);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBoxSearchParts);
            this.groupBox1.Controls.Add(this.buttonSearchParts);
            this.groupBox1.Controls.Add(this.labelParts);
            this.groupBox1.Controls.Add(this.buttonDeleteParts);
            this.groupBox1.Controls.Add(this.buttonModifyParts);
            this.groupBox1.Controls.Add(this.buttonAddParts);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 297);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(395, 239);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 34;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.Location = new System.Drawing.Point(25, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 146);
            this.dataGridView1.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PartID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // textBoxSearchParts
            // 
            this.textBoxSearchParts.Location = new System.Drawing.Point(207, 23);
            this.textBoxSearchParts.Name = "textBoxSearchParts";
            this.textBoxSearchParts.Size = new System.Drawing.Size(235, 20);
            this.textBoxSearchParts.TabIndex = 32;
            // 
            // buttonSearchParts
            // 
            this.buttonSearchParts.Location = new System.Drawing.Point(102, 17);
            this.buttonSearchParts.Name = "buttonSearchParts";
            this.buttonSearchParts.Size = new System.Drawing.Size(79, 33);
            this.buttonSearchParts.TabIndex = 31;
            this.buttonSearchParts.Text = "Search";
            this.buttonSearchParts.UseVisualStyleBackColor = true;
            this.buttonSearchParts.Click += new System.EventHandler(this.buttonSearchParts_Click);
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParts.Location = new System.Drawing.Point(23, 22);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(46, 21);
            this.labelParts.TabIndex = 29;
            this.labelParts.Text = "Parts";
            // 
            // buttonDeleteParts
            // 
            this.buttonDeleteParts.Location = new System.Drawing.Point(188, 235);
            this.buttonDeleteParts.Name = "buttonDeleteParts";
            this.buttonDeleteParts.Size = new System.Drawing.Size(79, 31);
            this.buttonDeleteParts.TabIndex = 28;
            this.buttonDeleteParts.Text = "Delete";
            this.buttonDeleteParts.UseVisualStyleBackColor = true;
            this.buttonDeleteParts.Click += new System.EventHandler(this.buttonDeleteParts_Click);
            // 
            // buttonModifyParts
            // 
            this.buttonModifyParts.Location = new System.Drawing.Point(103, 235);
            this.buttonModifyParts.Name = "buttonModifyParts";
            this.buttonModifyParts.Size = new System.Drawing.Size(79, 31);
            this.buttonModifyParts.TabIndex = 27;
            this.buttonModifyParts.Text = "Modify Part";
            this.buttonModifyParts.UseVisualStyleBackColor = true;
            this.buttonModifyParts.Click += new System.EventHandler(this.buttonModifyParts_Click);
            // 
            // buttonAddParts
            // 
            this.buttonAddParts.Location = new System.Drawing.Point(18, 234);
            this.buttonAddParts.Name = "buttonAddParts";
            this.buttonAddParts.Size = new System.Drawing.Size(79, 31);
            this.buttonAddParts.TabIndex = 26;
            this.buttonAddParts.Text = "Add Part";
            this.buttonAddParts.UseVisualStyleBackColor = true;
            this.buttonAddParts.Click += new System.EventHandler(this.buttonAddParts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteProducts);
            this.groupBox2.Controls.Add(this.dataGridViewProductsMain);
            this.groupBox2.Controls.Add(this.labelProducts);
            this.groupBox2.Controls.Add(this.buttonModifyProduct);
            this.groupBox2.Controls.Add(this.buttonAddProduct);
            this.groupBox2.Controls.Add(this.textBoxSearchProducts);
            this.groupBox2.Controls.Add(this.buttonSearchProducts);
            this.groupBox2.Location = new System.Drawing.Point(539, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 297);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // buttonDeleteProducts
            // 
            this.buttonDeleteProducts.Location = new System.Drawing.Point(196, 234);
            this.buttonDeleteProducts.Name = "buttonDeleteProducts";
            this.buttonDeleteProducts.Size = new System.Drawing.Size(79, 31);
            this.buttonDeleteProducts.TabIndex = 30;
            this.buttonDeleteProducts.Text = "Delete";
            this.buttonDeleteProducts.UseVisualStyleBackColor = true;
            this.buttonDeleteProducts.Click += new System.EventHandler(this.buttonDeleteProducts_Click);
            // 
            // dataGridViewProductsMain
            // 
            this.dataGridViewProductsMain.AllowUserToAddRows = false;
            this.dataGridViewProductsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductsMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewProductsMain.Location = new System.Drawing.Point(15, 75);
            this.dataGridViewProductsMain.Name = "dataGridViewProductsMain";
            this.dataGridViewProductsMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductsMain.Size = new System.Drawing.Size(445, 146);
            this.dataGridViewProductsMain.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(11, 22);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(70, 21);
            this.labelProducts.TabIndex = 28;
            this.labelProducts.Text = "Products";
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.Location = new System.Drawing.Point(100, 235);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(90, 31);
            this.buttonModifyProduct.TabIndex = 27;
            this.buttonModifyProduct.Text = "Modify Product";
            this.buttonModifyProduct.UseVisualStyleBackColor = true;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click_1);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(15, 233);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(79, 32);
            this.buttonAddProduct.TabIndex = 26;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click_1);
            // 
            // textBoxSearchProducts
            // 
            this.textBoxSearchProducts.Location = new System.Drawing.Point(185, 22);
            this.textBoxSearchProducts.Name = "textBoxSearchProducts";
            this.textBoxSearchProducts.Size = new System.Drawing.Size(235, 20);
            this.textBoxSearchProducts.TabIndex = 25;
            // 
            // buttonSearchProducts
            // 
            this.buttonSearchProducts.Location = new System.Drawing.Point(100, 17);
            this.buttonSearchProducts.Name = "buttonSearchProducts";
            this.buttonSearchProducts.Size = new System.Drawing.Size(79, 33);
            this.buttonSearchProducts.TabIndex = 24;
            this.buttonSearchProducts.Text = "Search";
            this.buttonSearchProducts.UseVisualStyleBackColor = true;
            this.buttonSearchProducts.Click += new System.EventHandler(this.buttonSearchProducts_Click);
            // 
            // labelInventoryManagement
            // 
            this.labelInventoryManagement.AutoSize = true;
            this.labelInventoryManagement.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryManagement.Location = new System.Drawing.Point(12, 24);
            this.labelInventoryManagement.Name = "labelInventoryManagement";
            this.labelInventoryManagement.Size = new System.Drawing.Size(249, 21);
            this.labelInventoryManagement.TabIndex = 26;
            this.labelInventoryManagement.Text = "Inventory Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1041, 419);
            this.Controls.Add(this.labelInventoryManagement);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Search";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearchParts;
        private System.Windows.Forms.Button buttonSearchParts;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Button buttonDeleteParts;
        private System.Windows.Forms.Button buttonModifyParts;
        private System.Windows.Forms.Button buttonAddParts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeleteProducts;
        private System.Windows.Forms.DataGridView dataGridViewProductsMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button buttonModifyProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxSearchProducts;
        private System.Windows.Forms.Button buttonSearchProducts;
        private System.Windows.Forms.Label labelInventoryManagement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

