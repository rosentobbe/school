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
        FileHandler FH = new FileHandler();
        
        public List<Product> getAvailableProducts()
        {
            return allProducts;
        }

        public Product getProductWithID(int ID)
        {
            return allProducts.FirstOrDefault(product => product.P_ID == ID);
        }
        public List<Product> addNewProduct(string productName, int p_ID, decimal price, int balance)
        {
            allProducts.Add(new Product(productName, p_ID, price, balance));
            return allProducts;
        }
        
        public bool saveStorage()
        {
            return FH.saveProductsToFile(allProducts);
        }

        public void loadStorage()
        {
            allProducts = FH.loadProductsFromFile();
        }

        public void removeProduct(int index)
        {
            allProducts.RemoveAt(index);
        }

        public void increaseBalance(int target_P_ID, int balance)
        {
            foreach(Product x in allProducts)
            {
                if(x.P_ID == target_P_ID)
                {
                    x.Balance = x.Balance + balance;
                }
            }
        }
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
        public bool isStoreEmpty()
        {
            return !allProducts.Any();
        }
    }
}
