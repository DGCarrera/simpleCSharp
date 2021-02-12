using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstSchoolCProj
{
    public partial class ModifyParts : Form
    {
        public ModifyParts()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            labelCompanyMachineID.Text = "Machine ID";
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelCompanyMachineID.Text = "Company Name";
        }

        public void SetModifyParts(Part tempPartPass) {

           Part tempPart = tempPartPass;
            Console.WriteLine(tempPart.GetType().ToString());
           
            if (tempPart.GetType().ToString() == "FirstSchoolCProj.Outsourced") {
                Outsourced tempPart2 = (Outsourced)tempPart;
                textBoxID.Text = tempPart.PartID.ToString();
                textBoxInStock.Text = tempPart.InStock.ToString();
                textBoxName.Text = tempPart.Name.ToString();
                textBoxPrice.Text = tempPart.Price.ToString();
                textBoxMax.Text = tempPart.Max.ToString();
                textBoxMin.Text = tempPart.Min.ToString();
                textBoxLast.Text = tempPart2.CompanyName.ToString();
                radioButtonOutsourced.Checked = true;
            }
            if (tempPart.GetType().ToString() == "FirstSchoolCProj.Inhouse") {

                Inhouse tempPart2 = (Inhouse)tempPart;
                textBoxID.Text = tempPart.PartID.ToString();
                textBoxInStock.Text = tempPart.InStock.ToString();
                textBoxName.Text = tempPart.Name.ToString();
                textBoxPrice.Text = tempPart.Price.ToString();
                textBoxMax.Text = tempPart.Max.ToString();
                textBoxMin.Text = tempPart.Min.ToString();
                textBoxLast.Text = tempPart2.MachineID.ToString();
                radioButtonInHouse.Checked = true;
            }
            
                
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonInHouse.Checked == true)
                {
                    Inhouse tempPart = new Inhouse();
                    int tempId = int.Parse(textBoxID.Text);
                    tempPart.PartID = int.Parse(textBoxID.Text);
                    tempPart.Name = textBoxName.Text;
                    tempPart.InStock = int.Parse(textBoxInStock.Text);
                    tempPart.Price = int.Parse(textBoxPrice.Text);
                    tempPart.Max = int.Parse(textBoxMax.Text);

                    int n;
                    bool isInt = int.TryParse(textBoxMin.Text, out n);

                    if (isInt == true)
                    {

                        tempPart.Min = int.Parse(textBoxMin.Text);

                    }
                    else
                    {
                        throw new Exception("Please insert a number into min");
                    }
                    
                    tempPart.MachineID = int.Parse(textBoxLast.Text);
                    mainObjects.myInventory.ReplaceParts(tempId, tempPart);
                    Close();

                }
                else if (radioButtonOutsourced.Checked == true)
                {
                    Outsourced tempPart = new Outsourced();
                    int tempId = int.Parse(textBoxID.Text);
                    tempPart.PartID = int.Parse(textBoxID.Text);
                    tempPart.Name = textBoxName.Text;
                    tempPart.InStock = int.Parse(textBoxInStock.Text);
                    tempPart.Price = int.Parse(textBoxPrice.Text);
                    tempPart.Max = int.Parse(textBoxMax.Text);
                    int n;
                    bool isInt = int.TryParse(textBoxMin.Text, out n);

                    if (isInt == true)
                    {

                        tempPart.Min = int.Parse(textBoxMin.Text);

                    }
                    else
                    {
                        throw new Exception("Please insert a number into min");
                    }
                    tempPart.CompanyName = textBoxLast.Text;
                    mainObjects.myInventory.ReplaceParts(tempId, tempPart);
                    Close();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }

            
        }
    }
}
