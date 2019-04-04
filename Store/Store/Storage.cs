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
        public List<Product> addNewProduct(string productName, int p_ID, decimal price, int balance)
        {
            allProducts.Add(new Product(productName, p_ID, price, balance));
            return allProducts;
        }
        public void removeProduct(int index)
        {
            allProducts.RemoveAt(index);
        }
        public void productExists()
        {

        }
        public void increaseBalance()
        {

        }
        public void decreaseBalance()
        {

        }
        public bool isStoreEmpty()
        {
            return !allProducts.Any();
        }
    }
}
