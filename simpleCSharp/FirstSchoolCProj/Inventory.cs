using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FirstSchoolCProj
{
    public class Inventory
    {
        
        private ArrayList Products = new ArrayList();
        public ArrayList allParts = new ArrayList();


        //Parts
        public bool removePartByIndex(int index)
        {
            
            allParts.RemoveAt(index);
            return true;
        }

        public bool ReplaceParts(int partID, Part partI)
        {
            for (int i = 0; i < allParts.Count; i++)
            {
                Part tempPart = (Part)allParts[i];
                if (tempPart.PartID == partID)
                {
                    allParts.RemoveAt(i);
                    allParts.Insert(i, partI);
                    return true;
                }
            }
            return false;
        }
               
        // used in fillGridView
        public int AllPartsCounter() {

            return allParts.Count;
        }
        // used in fillGridView
        public Part IterateAllPartsList(int tempCounter) {

            Part tempObj = (Part)allParts[tempCounter];
            return tempObj;

        }
        
        //when called this needs to be in a catch and throw
        public Part LookUpPart(int partID ) {

            for(int i = 0; i < allParts.Count; i++ ) {
                Part tempPart = (Part)allParts[i];
                int tempPartID =  tempPart.PartID;  
                if (tempPartID == partID  ) {
                      return tempPart; 
                }
            }
            throw new Exception("Part does not exist");           
        }

        public void AddPart(Part tempObj)
        {

            allParts.Add(tempObj);
            

        }

        // connect bool to message in front (Part deleted/ delete failed)
        public bool DeletePart(int partID ) {
            for (int i = 0; i < allParts.Count; i++) {
                Part tempPart = (Part)allParts[i];
                if (partID == tempPart.PartID) {
                    allParts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        //Use with catch and throw
        public void ModifyPart(int partID, Part tempObj)
        {
            for (int i = 0; i < allParts.Count; i++)
            {
                Part tempPart = (Part)allParts[i];
                if (partID == tempPart.PartID)
                {
                    allParts[i] = tempObj; 
                }
            }
            throw new Exception("Part does not exist");
        }




        //Products
       
        public bool removeProductByIndex(int index)
        {

            Products.RemoveAt(index);
            return true;
        }
        // used in fillGridView
        public int ProductsCounter()
        {

            return Products.Count;
        }
        // used in fillGridView
        public Product IterateProductsList(int tempCounter)
        {

            Product tempObj = (Product)Products[tempCounter];
            return tempObj;

        }

        public bool RemoveProduct(int productID) {
            for (int i = 0; i < Products.Count; i++) {
                Product tempProduct = (Product)Products[i]; 
                if (tempProduct.ProductID == productID) {
                    Products.RemoveAt(i);
                    return true; 
                }
            }
            return false;
        }

        public bool ReplaceProduct(int productID, Product productI)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Product tempProduct = (Product)Products[i];
                if (tempProduct.ProductID == productID)
                {
                    Products.RemoveAt(i);
                    Products.Insert(i, productI);
                    return true;
                }
            }
            return false;
        }

        public void AddProduct(Product tempProduct) {
            Products.Add(tempProduct);
        }

        public Product FindProductByIndex(int index) {
            Product tempProduct = new Product();
            tempProduct = (Product)Products[index];
            return tempProduct;
        }

        //use catch and throw 
        public void UpdateProduct(int tempID, Product tempProduct) {
            for (int i = 0; i < Products.Count; i++  ) {
                Product tempModifyProduct = (Product)Products[i];
                if (tempModifyProduct.ProductID == tempID ) {
                    Products[i] = tempProduct;
                }
            }
            throw new Exception("Product does not exist");
        }

        public Product LookUpProduct(int tempID) {
            for (int i = 0; i < Products.Count; i++ ) {
                Product tempProduct = (Product)Products[i];
                if (tempProduct.ProductID == tempID) {
                    return tempProduct;
                }
            }
            throw new Exception("Product does not exist");
        }



        // end
    }         
}
