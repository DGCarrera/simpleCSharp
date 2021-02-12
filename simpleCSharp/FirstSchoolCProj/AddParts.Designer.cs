namespace FirstSchoolCProj
{
    partial class AddParts
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
            this.inHouseRadioB = new System.Windows.Forms.RadioButton();
            this.outSourcedRadioB = new System.Windows.Forms.RadioButton();
            this.labelAddModifyParts = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelInventoryLevel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelCompanyMachineID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventoryLevel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMachineIdCompany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inHouseRadioB
            // 
            this.inHouseRadioB.AutoSize = true;
            this.inHouseRadioB.Checked = true;
            this.inHouseRadioB.Location = new System.Drawing.Point(151, 55);
            this.inHouseRadioB.Name = "inHouseRadioB";
            this.inHouseRadioB.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadioB.TabIndex = 0;
            this.inHouseRadioB.TabStop = true;
            this.inHouseRadioB.Text = "In-House";
            this.inHouseRadioB.UseVisualStyleBackColor = true;
            this.inHouseRadioB.CheckedChanged += new System.EventHandler(this.inHouseRadioB_CheckedChanged);
            // 
            // outSourcedRadioB
            // 
            this.outSourcedRadioB.AutoSize = true;
            this.outSourcedRadioB.Location = new System.Drawing.Point(242, 55);
            this.outSourcedRadioB.Name = "outSourcedRadioB";
            this.outSourcedRadioB.Size = new System.Drawing.Size(80, 17);
            this.outSourcedRadioB.TabIndex = 1;
            this.outSourcedRadioB.Text = "Outsourced";
            this.outSourcedRadioB.UseVisualStyleBackColor = true;
            this.outSourcedRadioB.CheckedChanged += new System.EventHandler(this.outSourcedRadioB_CheckedChanged);
            this.outSourcedRadioB.Click += new System.EventHandler(this.outSourcedRadioB_Click);
            // 
            // labelAddModifyParts
            // 
            this.labelAddModifyParts.AutoSize = true;
            this.labelAddModifyParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddModifyParts.Location = new System.Drawing.Point(186, 20);
            this.labelAddModifyParts.Name = "labelAddModifyParts";
            this.labelAddModifyParts.Size = new System.Drawing.Size(79, 20);
            this.labelAddModifyParts.TabIndex = 2;
            this.labelAddModifyParts.Text = "Add Parts";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(144, 391);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 31);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(236, 391);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 31);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 143);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 108);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            // 
            // labelInventoryLevel
            // 
            this.labelInventoryLevel.AutoSize = true;
            this.labelInventoryLevel.Location = new System.Drawing.Point(57, 177);
            this.labelInventoryLevel.Name = "labelInventoryLevel";
            this.labelInventoryLevel.Size = new System.Drawing.Size(80, 13);
            this.labelInventoryLevel.TabIndex = 7;
            this.labelInventoryLevel.Text = "Inventory Level";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(53, 213);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(53, 246);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(53, 283);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 10;
            this.labelMin.Text = "Min";
            // 
            // labelCompanyMachineID
            // 
            this.labelCompanyMachineID.AutoSize = true;
            this.labelCompanyMachineID.Location = new System.Drawing.Point(52, 318);
            this.labelCompanyMachineID.Name = "labelCompanyMachineID";
            this.labelCompanyMachineID.Size = new System.Drawing.Size(62, 13);
            this.labelCompanyMachineID.TabIndex = 11;
            this.labelCompanyMachineID.Text = "Machine ID";
            this.labelCompanyMachineID.Click += new System.EventHandler(this.labelCompanyMachineID_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(150, 105);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(171, 20);
            this.textBoxID.TabIndex = 12;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 140);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(171, 20);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxInventoryLevel
            // 
            this.textBoxInventoryLevel.Location = new System.Drawing.Point(150, 174);
            this.textBoxInventoryLevel.Name = "textBoxInventoryLevel";
            this.textBoxInventoryLevel.Size = new System.Drawing.Size(170, 20);
            this.textBoxInventoryLevel.TabIndex = 14;
            this.textBoxInventoryLevel.TextChanged += new System.EventHandler(this.textBoxInventoryLevel_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(150, 208);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(170, 20);
            this.textBoxPrice.TabIndex = 15;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(151, 239);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(169, 20);
            this.textBoxMax.TabIndex = 16;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(150, 280);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(169, 20);
            this.textBoxMin.TabIndex = 17;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // textBoxMachineIdCompany
            // 
            this.textBoxMachineIdCompany.Location = new System.Drawing.Point(150, 311);
            this.textBoxMachineIdCompany.Name = "textBoxMachineIdCompany";
            this.textBoxMachineIdCompany.Size = new System.Drawing.Size(168, 20);
            this.textBoxMachineIdCompany.TabIndex = 18;
            this.textBoxMachineIdCompany.TextChanged += new System.EventHandler(this.textBoxMachineIdCompany_TextChanged);
            // 
            // AddParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.textBoxMachineIdCompany);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventoryLevel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelCompanyMachineID);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventoryLevel);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAddModifyParts);
            this.Controls.Add(this.outSourcedRadioB);
            this.Controls.Add(this.inHouseRadioB);
            this.Name = "AddParts";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.AddParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inHouseRadioB;
        private System.Windows.Forms.RadioButton outSourcedRadioB;
        private System.Windows.Forms.Label labelAddModifyParts;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelInventoryLevel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelCompanyMachineID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventoryLevel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMachineIdCompany;
    }
}