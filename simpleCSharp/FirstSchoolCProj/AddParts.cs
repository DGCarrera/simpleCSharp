using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstSchoolCProj;

namespace FirstSchoolCProj
{
    public partial class AddParts : Form
    {
        public AddParts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (outSourcedRadioB.Checked == true)
                {
                    Outsourced tempObj = new Outsourced();
                    int n;
                    bool isInt = int.TryParse(textBoxMin.Text, out n);

                    if (isInt == true)
                    {

                        tempObj.Min = int.Parse(textBoxMin.Text);

                    }
                    else
                    {
                        throw new Exception("Please insert a number into min");
                    }
                    tempObj.PartID = int.Parse(textBoxID.Text);
                    tempObj.Name = textBoxName.Text;
                    tempObj.InStock = int.Parse(textBoxInventoryLevel.Text);
                    tempObj.Price = int.Parse(textBoxPrice.Text);
                    tempObj.Max = int.Parse(textBoxMax.Text);
                    tempObj.CompanyName = textBoxMachineIdCompany.Text;



                    mainObjects.myInventory.AddPart(tempObj);





                    Close();
                }
                else if (inHouseRadioB.Checked == true)
                {
                    Inhouse tempObj = new Inhouse();
                    tempObj.PartID = int.Parse(textBoxID.Text);
                    tempObj.Name = textBoxName.Text;
                    tempObj.InStock = int.Parse(textBoxInventoryLevel.Text);
                    tempObj.Price = int.Parse(textBoxPrice.Text);
                    tempObj.Max = int.Parse(textBoxMax.Text);
                    int n;
                    bool isInt = int.TryParse(textBoxMin.Text, out n );
                    
                    if (isInt == true) {

                            tempObj.Min = int.Parse(textBoxMin.Text);

                    } else {
                        throw new Exception("Please insert a number into min");
                    }

                    tempObj.MachineID = int.Parse(textBoxMachineIdCompany.Text);



                    mainObjects.myInventory.AddPart(tempObj);

                    // Form1.dataGridViewPartsMain.Refresh; 

                    Close();
                };
            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
               
        }

        private void outSourcedRadioB_Click(object sender, EventArgs e)
        {
            labelCompanyMachineID.Text = "Company Name";
        }

        private void labelCompanyMachineID_Click(object sender, EventArgs e)
        {

        }

        private void inHouseRadioB_CheckedChanged(object sender, EventArgs e)
        {
            labelCompanyMachineID.Text = "Machine Id";
        }

        public void setWindowName(string name) {

            labelAddModifyParts.Text = name; 
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInventoryLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMachineIdCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void outSourcedRadioB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddParts_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
