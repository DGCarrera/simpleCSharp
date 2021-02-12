using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstSchoolCProj;

namespace FirstSchoolCProj
{
    public static class mainObjects
    {
        public static Inventory myInventory = new Inventory();

        
        public static void InitializeInventory()
        {

            Inhouse first = new Inhouse
            {
                PartID = 1254,
                Name = "Wrench",
                Max = 100,
                Min = 10,
                Price = 100,
                InStock = 50,
                MachineID = 022214
            };

            Outsourced second = new Outsourced
            {
                PartID = 2222,
                Name = "bolt",
                Max = 100,
                Min = 10,
                Price = 100,
                InStock = 40,
                CompanyName = "Umbrella"
        }; 
          

            Product third = new Product();
            third.ProductID = 333;
            third.Name = "Motor";
            third.Max = 100;
            third.Min = 10;
            third.Price = 1000;
            third.ProductID = 33546;
            third.AddAssociatedPart(first); 

            myInventory.AddPart(first);
            myInventory.AddPart(second);
             myInventory.AddProduct(third);
            
            
        }

       

    }
}
