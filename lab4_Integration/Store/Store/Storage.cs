using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Storage
    {
        List<Product> allProducts = new List<Product>();
        ProductFileHandler FH = new ProductFileHandler();
        
        //Returns a list of all products that are in the store.
        public List<Product> getAvailableProducts()
        {
            return allProducts;
        }
        //Collects and returns a specific product with the corresponding ID.
        public Product getProductWithID(int ID)
        {
            return allProducts.FirstOrDefault(product => product.P_ID == ID);
        }
        //Adds a new product to the store, with the given fields. Then return the new list of products.
        public List<Product> addNewProduct(string productName, int p_ID, decimal price, int balance)
        {
            allProducts.Add(new Product(productName, p_ID, price, balance));
            return allProducts;
        }
        //Calls the FH which is the fileHandler for the products. Saves the storage to csv.
        public bool saveStorage(bool exportToSimple = false)
        {
            return FH.saveProductsToFile(allProducts, exportToSimple);
        }
        //As the store opens all the products are loaded from file with the help of FH.
        public bool loadStorage(bool importSimple = false)
        {
            allProducts = FH.loadProductsFromFile(importSimple);
            return allProducts.Count != 0;

        }
        //Removes the product with the corresponding product ID.
        public void removeProduct(int product_id)
        {
            foreach(Product x in allProducts)
            {
                if(product_id == x.P_ID)
                {
                    allProducts.Remove(x);
                    break;
                }
            }
        }
        //Increases the balance of a product with the given ID.
        public void increaseBalance(int target_P_ID, int balance)
        {
            foreach(Product x in allProducts)
            {
                if(x.P_ID == target_P_ID)
                    x.Balance = x.Balance + balance;
            }
        }
        //Decreases the balance of a product with the given ID.
        public void decreaseBalance(int P_id, int balance)
        {
            foreach(Product x in allProducts)
            {
                if(x.P_ID == P_id)
                {
                    x.Balance = x.Balance - balance;
                    break;
                }
            }
        }
        //Checks wheter the store has no registered products.
        public bool isStoreEmpty()
        {
            return !allProducts.Any();
        }
    }
}
