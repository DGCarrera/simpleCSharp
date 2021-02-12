namespace FirstSchoolCProj
{
    partial class AddProduct
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
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.DeletePart = new System.Windows.Forms.Button();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductInventory = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductMax = new System.Windows.Forms.Label();
            this.labelProductMin = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAddModifyProduct = new System.Windows.Forms.Label();
            this.dataGridViewAddedPart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedPart)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(130, 433);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 27);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(223, 433);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 27);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(717, 243);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(84, 27);
            this.AddPart.TabIndex = 4;
            this.AddPart.Text = "Add Part";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // DeletePart
            // 
            this.DeletePart.Location = new System.Drawing.Point(717, 433);
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(84, 27);
            this.DeletePart.TabIndex = 5;
            this.DeletePart.Text = "Delete Part";
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(47, 94);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(18, 13);
            this.labelProductID.TabIndex = 6;
            this.labelProductID.Text = "ID";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(47, 122);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(35, 13);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Name";
            // 
            // labelProductInventory
            // 
            this.labelProductInventory.AutoSize = true;
            this.labelProductInventory.Location = new System.Drawing.Point(47, 146);
            this.labelProductInventory.Name = "labelProductInventory";
            this.labelProductInventory.Size = new System.Drawing.Size(80, 13);
            this.labelProductInventory.TabIndex = 8;
            this.labelProductInventory.Text = "Inventory Level";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(44, 172);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(31, 13);
            this.labelProductPrice.TabIndex = 9;
            this.labelProductPrice.Text = "Price";
            // 
            // labelProductMax
            // 
            this.labelProductMax.AutoSize = true;
            this.labelProductMax.Location = new System.Drawing.Point(44, 206);
            this.labelProductMax.Name = "labelProductMax";
            this.labelProductMax.Size = new System.Drawing.Size(27, 13);
            this.labelProductMax.TabIndex = 10;
            this.labelProductMax.Text = "Max";
            // 
            // labelProductMin
            // 
            this.labelProductMin.AutoSize = true;
            this.labelProductMin.Location = new System.Drawing.Point(44, 231);
            this.labelProductMin.Name = "labelProductMin";
            this.labelProductMin.Size = new System.Drawing.Size(24, 13);
            this.labelProductMin.TabIndex = 11;
            this.labelProductMin.Text = "Min";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(452, 22);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(179, 20);
            this.textSearch.TabIndex = 12;
            // 
            // textBoxID
            // 
            this.textBoxID.AcceptsTab = true;
            this.textBoxID.Location = new System.Drawing.Point(130, 91);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(178, 20);
            this.textBoxID.TabIndex = 13;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.AcceptsTab = true;
            this.textBoxName.Location = new System.Drawing.Point(130, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 20);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.AcceptsTab = true;
            this.textBoxInventory.Location = new System.Drawing.Point(130, 143);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(178, 20);
            this.textBoxInventory.TabIndex = 15;
            this.textBoxInventory.TextChanged += new System.EventHandler(this.textBoxInventory_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AcceptsTab = true;
            this.textBoxPrice.Location = new System.Drawing.Point(130, 169);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(179, 20);
            this.textBoxPrice.TabIndex = 16;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.AcceptsTab = true;
            this.textBoxMax.Location = new System.Drawing.Point(130, 199);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(179, 20);
            this.textBoxMax.TabIndex = 17;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.AcceptsTab = true;
            this.textBoxMin.Location = new System.Drawing.Point(130, 228);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(177, 20);
            this.textBoxMin.TabIndex = 18;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(357, 22);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(68, 21);
            this.buttonProductSearch.TabIndex = 19;
            this.buttonProductSearch.Text = "Search";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.ColumnPartName,
            this.ColumnPartInventory,
            this.ColumnPrice});
            this.dataGridViewList.Location = new System.Drawing.Point(356, 91);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(445, 146);
            this.dataGridViewList.TabIndex = 20;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // columnID
            // 
            this.columnID.HeaderText = "Part ID";
            this.columnID.Name = "columnID";
            // 
            // ColumnPartName
            // 
            this.ColumnPartName.HeaderText = "Part Name";
            this.ColumnPartName.Name = "ColumnPartName";
            // 
            // ColumnPartInventory
            // 
            this.ColumnPartInventory.HeaderText = "Inventory Level";
            this.ColumnPartInventory.Name = "ColumnPartInventory";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price Per Unit";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // labelAddModifyProduct
            // 
            this.labelAddModifyProduct.AutoSize = true;
            this.labelAddModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddModifyProduct.Location = new System.Drawing.Point(30, 20);
            this.labelAddModifyProduct.Name = "labelAddModifyProduct";
            this.labelAddModifyProduct.Size = new System.Drawing.Size(97, 20);
            this.labelAddModifyProduct.TabIndex = 22;
            this.labelAddModifyProduct.Text = "Add Product";
            this.labelAddModifyProduct.Click += new System.EventHandler(this.labelAddModifyProduct_Click);
            // 
            // dataGridViewAddedPart
            // 
            this.dataGridViewAddedPart.AllowUserToAddRows = false;
            this.dataGridViewAddedPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddedPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewAddedPart.Location = new System.Drawing.Point(357, 281);
            this.dataGridViewAddedPart.Name = "dataGridViewAddedPart";
            this.dataGridViewAddedPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddedPart.Size = new System.Drawing.Size(445, 146);
            this.dataGridViewAddedPart.TabIndex = 23;
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
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 475);
            this.Controls.Add(this.dataGridViewAddedPart);
            this.Controls.Add(this.labelAddModifyProduct);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.buttonProductSearch);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.labelProductMin);
            this.Controls.Add(this.labelProductMax);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductInventory);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Name = "AddProduct";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductInventory;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductMax;
        private System.Windows.Forms.Label labelProductMin;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Label labelAddModifyProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridView dataGridViewAddedPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}