using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Register
    {
        int currentID { get; set; }
        public decimal totalSum { get; set; }

        private ReceiptHandler RH       = new ReceiptHandler();
        private StatisticHandler SH     = new StatisticHandler();

        List<StatisticProduct> salesStatus = new List<StatisticProduct>();
        List<Product> currentCart = new List<Product>();

        //Called when a customer wants to pay. Adds sales to statistic, updates the price and calls printer.
        public void checkout()
        {
            addToStatistic(currentCart);
            update_totalPrice();
            RH.printRecipt(currentCart, totalSum.ToString());
        }
        //Clears the list containing products and updates total price.
        public void clear()
        {
            currentCart.Clear();
            update_totalPrice();
        }
        //Checks if the cart is empty.
        public bool isCartEmpty()
        {
            if (currentCart.Count > 0)
                return false;
            return true;
        }
        //Adds a product with the given fields into the cart.
        public void add(int product_ID, string product_Name, decimal product_Price, int balance)
        {
            if (!updateBalance(product_ID, product_Price, balance))
            {
                currentCart.Add(new Product(product_Name, product_ID, product_Price * balance, balance));
            }
            update_totalPrice();
        }
        //Updates the total price for all the products in the cart.
        public void update_totalPrice()
        {
            decimal temp_sum = 0;
            foreach(Product x in currentCart)
            {
                temp_sum = temp_sum + x.Price;
            }
            totalSum = (int)temp_sum;
        }

        //Updates the balance if product exists in cart. Otherwise returns false if not found.
        public bool updateBalance(int req_P_ID, decimal product_price, int balance)
        {
            foreach(Product x in currentCart)
            {
                if(x.P_ID == req_P_ID)
                {
                    x.Price = x.Price + (product_price * balance);
                    x.Balance = x.Balance + balance;
                    return true;
                }
            }
            return false;
        }
        //Adds all given products to the sales statistic.
        private void addToStatistic(List<Product> currentCart)
        {
            foreach(Product x in currentCart)
            {
                salesStatus.Add(new StatisticProduct(DateTime.Now.ToShortDateString(), x.Name, x.P_ID, x.Balance));
            }
        }

        //Calls SH which save sales to a file.
        public void saveProductToStatistic()
        { 
            SH.saveProductsToFile(salesStatus);
        }

        //Calls SH which will load sales statistics upon start up.
        public void loadProductStatistic()
        {
            salesStatus = SH.loadProductsFromFile();
        }

        //Returns the list containing sale statistics.
        public List<StatisticProduct> getStatisticList()
        {
            return salesStatus;
        }

        //Collects the product at a given index in the cart.
        public Product GetProductAtIndex(int index)
        {
            return currentCart.ElementAt(index);
        }

        //Removes the product at the given index and also updates the total price.
        public void remove(int index)
        {
            if (currentCart.Count > index)
            {
                currentCart.RemoveAt(index);
            }
            update_totalPrice();
        }

        //Returns the list containing all prudcts that are currently in the cart.
        public List<Product> getAllProductsInCart()
        {
            return currentCart;
        }
    }
}
