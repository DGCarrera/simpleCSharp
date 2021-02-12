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

    public partial class ModifyProduct : Form
    {
        Product tempProduct = new Product();

        public ModifyProduct()
        {
            InitializeComponent();
            FillGridModifyParts();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dataGridViewList.SelectedRows[0].Cells[0].Value.ToString());

            Part tempPart = mainObjects.myInventory.LookUpPart(int.Parse(dataGridViewList.SelectedRows[0].Cells[0].Value.ToString()));
            string[] tempArray = new string[7];
            tempArray[0] = tempPart.PartID.ToString();
            tempArray[1] = tempPart.Name;
            tempArray[2] = tempPart.InStock.ToString();
            tempArray[3] = tempPart.Price.ToString();

            dataGridViewAddedPart.Rows.Add(tempArray);
            tempProduct.AddAssociatedPart(tempPart);
        }

        public void FillGridModifyParts()
        {
            int counter = mainObjects.myInventory.AllPartsCounter();
            for (int i = 0; i < counter; i++)
            {
                Part tempObj = mainObjects.myInventory.IterateAllPartsList(i);
                string[] tempArray = new string[7];
                tempArray[0] = tempObj.PartID.ToString();
                tempArray[1] = tempObj.Name;
                tempArray[2] = tempObj.InStock.ToString();
                tempArray[3] = tempObj.Price.ToString();

                dataGridViewList.Rows.Add(tempArray);


            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddedPart.RowCount > 0)
            {
                Console.WriteLine(dataGridViewAddedPart.RowCount.ToString());
                foreach (DataGridViewRow item in this.dataGridViewAddedPart.SelectedRows)
                {
                    int index = item.Index; 
                    dataGridViewAddedPart.Rows.RemoveAt(index);
                    tempProduct.removeAssociatedPartByIndex(index);
                }
            }
        }

        public void SetModifyProducts(Product tempProductPass)
        {

            tempProduct = tempProductPass;
            Console.WriteLine(tempProduct.GetType().ToString());



            textBoxID.Text = tempProduct.ProductID.ToString();
            textBoxInventory.Text = tempProduct.InStock.ToString();
            textBoxName.Text = tempProduct.Name.ToString();
            textBoxPrice.Text = tempProduct.Price.ToString();
            textBoxMax.Text = tempProduct.Max.ToString();
            textBoxMin.Text = tempProduct.Min.ToString();

            int counter = tempProduct.AssociatedPartCounter();
            
            for (int i = 0; i < counter; i++) {
               Part tempPart = tempProduct.PassAssociatedPartsList(i);
                
                string[] tempArray = new string[7];
                tempArray[0] = tempPart.PartID.ToString();
                tempArray[1] = tempPart.Name;
                tempArray[2] = tempPart.InStock.ToString();
                tempArray[3] = tempPart.Price.ToString();

                dataGridViewAddedPart.Rows.Add(tempArray);
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                int tempId = int.Parse(textBoxID.Text);
                tempProduct.ProductID = int.Parse(textBoxID.Text);
                tempProduct.Name = textBoxName.Text;
                tempProduct.InStock = int.Parse(textBoxInventory.Text);
                tempProduct.Price = int.Parse(textBoxPrice.Text);
                tempProduct.Max = int.Parse(textBoxMax.Text);
                int n;
                bool isInt = int.TryParse(textBoxMin.Text, out n);

                if (isInt == true)
                {

                    tempProduct.Min = int.Parse(textBoxMin.Text);

                }
                else
                {
                    throw new Exception("Please insert a number into min");
                }

                mainObjects.myInventory.ReplaceProduct(tempId, tempProduct);

                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumber = int.TryParse(textSearch.Text, out n);
            Console.WriteLine(isNumber);
            if (isNumber == true)
            {
                int tempID = int.Parse(textSearch.Text);
                Console.WriteLine(tempID);


                for (int i = 0; i < mainObjects.myInventory.AllPartsCounter(); i++)
                {

                    Part tempPart = mainObjects.myInventory.IterateAllPartsList(i);
                    int tempPID = tempPart.PartID;
                    Console.WriteLine("tempPID is ");
                    Console.WriteLine(tempPID);
                    if (tempPID == tempID)
                    {
                        dataGridViewList.ClearSelection();
                        dataGridViewList.Rows[i].Selected = true;
                        break;
                    }



                }
            }
            else
            {

                string tempName = textSearch.Text;
                for (int i = 0; i < mainObjects.myInventory.AllPartsCounter(); i++)
                {
                    Part tempPart = mainObjects.myInventory.IterateAllPartsList(i);
                    string tempPartName = tempPart.Name.ToLower();
                    tempName = tempName.ToLower();

                    if (tempPartName == tempName)
                    {
                        dataGridViewList.ClearSelection();
                        dataGridViewList.Rows[i].Selected = true;
                        break;
                    }


                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
