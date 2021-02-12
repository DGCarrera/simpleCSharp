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



    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            mainObjects.InitializeInventory();

            FillGridViewParts();
            // listBoxMain = mainObjects.myInventory.allParts; 
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddParts_Click(object sender, EventArgs e)
        {
            AddParts windowedParts = new AddParts();
            windowedParts.Show();
            windowedParts.setWindowName("Add Parts");
        }

        private void buttonModifyParts_Click(object sender, EventArgs e)
        {
            ModifyParts modifyParts = new ModifyParts();
            
            //Sets 
            Part tempPart = mainObjects.myInventory.LookUpPart(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) );
            modifyParts.SetModifyParts(tempPart);
            
            modifyParts.Show();


        }

        private void buttonAddProduct_Click_1(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            
        }

        private void buttonModifyProduct_Click_1(object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct();
            Product tempObj = mainObjects.myInventory.LookUpProduct(int.Parse(dataGridViewProductsMain.SelectedRows[0].Cells[0].Value.ToString()));
            //int indexProduct = dataGridViewProductsMain.SelectedRows.;
            modifyProduct.SetModifyProducts(tempObj);
            modifyProduct.Show();
            //refreshGridAllParts();


        }

       

        private void dataGridViewPartsMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refreshGridAllParts() {
            dataGridView1.Rows.Clear();
            FillGridViewParts();
        }

        public void FillGridViewParts() {
            
           int counter = mainObjects.myInventory.AllPartsCounter();
           for (int i = 0; i < counter; i++)
           {

               Part tempObj = mainObjects.myInventory.IterateAllPartsList(i);
               string[] tempArray = new string[7];
               tempArray[0] = tempObj.PartID.ToString();
               tempArray[1] = tempObj.Name;
               tempArray[2] = tempObj.InStock.ToString();
               tempArray[3] = tempObj.Price.ToString();

               dataGridView1.Rows.Add(tempArray);
               

        }
        
            

            int pCounter = mainObjects.myInventory.ProductsCounter();
            for (int j = 0; j < pCounter; j++) {
                Product tempObj = mainObjects.myInventory.IterateProductsList(j);
                string[] tempArray = new string[7];
                tempArray[0] = tempObj.ProductID.ToString();
                tempArray[1] = tempObj.Name.ToString();
                tempArray[2] = tempObj.InStock.ToString();
                tempArray[3] = tempObj.Price.ToString();
                dataGridViewProductsMain.Rows.Add(tempArray);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridViewProductsMain.Rows.Clear();
            FillGridViewParts();
            
            
            
            
        }

        private void buttonDeleteParts_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                Console.WriteLine(dataGridView1.RowCount.ToString());
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    int index = item.Index;
                    dataGridView1.Rows.RemoveAt(index);
                    mainObjects.myInventory.removePartByIndex(index);
                }
            }
        }

        private void buttonDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProductsMain.RowCount > 0)
                {
                    Console.WriteLine(dataGridViewProductsMain.RowCount.ToString());
                    foreach (DataGridViewRow item in this.dataGridViewProductsMain.SelectedRows)
                    {
                        int index = item.Index;
                        Product tempObj = mainObjects.myInventory.FindProductByIndex(index);
                        
                        if (tempObj.IsAssociatedParts() == false)
                        {
                            dataGridViewProductsMain.Rows.RemoveAt(index);
                            mainObjects.myInventory.removeProductByIndex(index);
                        }
                        else
                        {
                            throw new Exception("This product has an Associated Parts List. Please delete list to delete product");
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        //search button products
        private void buttonSearchProducts_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumber = int.TryParse(textBoxSearchProducts.Text, out n);
            if (isNumber == true) {
                int tempID = int.Parse(textBoxSearchProducts.Text);
                Console.WriteLine(tempID);


                for (int i = 0; i < mainObjects.myInventory.ProductsCounter(); i++) {

                    Product tempProduct = mainObjects.myInventory.IterateProductsList(i);
                    int tempPID = tempProduct.ProductID;
                    Console.WriteLine("tempPID is ");
                    Console.WriteLine(tempPID);
                    if ( tempPID == tempID)
                    {
                        dataGridViewProductsMain.ClearSelection();
                        dataGridViewProductsMain.Rows[i].Selected = true;
                        break;
                    }

                    

                }
            } else {

                string tempName = textBoxSearchProducts.Text;
                for (int i = 0; i < mainObjects.myInventory.ProductsCounter(); i++) {
                    Product tempProduct = mainObjects.myInventory.IterateProductsList(i);
                    string tempProductName = tempProduct.Name.ToLower();
                    tempName = tempName.ToLower();

                    if (tempProductName == tempName)
                    {
                        dataGridViewProductsMain.ClearSelection();
                        dataGridViewProductsMain.Rows[i].Selected = true;
                        break;
                    }
                    
                        
                    }
                }
            
        }
        //search button parts
        private void buttonSearchParts_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumber = int.TryParse(textBoxSearchParts.Text, out n);
            if (isNumber == true)
            {
                int tempID = int.Parse(textBoxSearchParts.Text);
                Console.WriteLine(tempID);


                for (int i = 0; i < mainObjects.myInventory.AllPartsCounter(); i++)
                {

                    Part tempPart = mainObjects.myInventory.IterateAllPartsList(i);
                    int tempPID = tempPart.PartID;
                    Console.WriteLine("tempPID is ");
                    Console.WriteLine(tempPID);
                    if (tempPID == tempID)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }



                }
            }
            else
            {

                string tempName = textBoxSearchParts.Text;
                for (int i = 0; i < mainObjects.myInventory.AllPartsCounter(); i++)
                {
                    Part tempPart = mainObjects.myInventory.IterateAllPartsList(i);
                    if (tempPart.Name.ToLower() == tempName.ToLower())
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }


                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridViewProductsMain.Rows.Clear();
            FillGridViewParts();
        }
    }
    }

    
    

