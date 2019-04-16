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

        public void checkout()
        {
            addToStatistic(currentCart);
            update_totalPrice();
            RH.printRecipt(currentCart, totalSum.ToString());
        }

        public void clear()
        {
            currentCart.Clear();
            update_totalPrice();
        }

        public bool isCartEmpty()
        {
            if (currentCart.Count > 0)
                return false;
            return true;
        }
        public void add(int product_ID, string product_Name, decimal product_Price, int balance)
        {
            if (!existInCart(product_ID, product_Price, balance))
            {
                currentCart.Add(new Product(product_Name, product_ID, product_Price * balance, balance));
            }
            update_totalPrice();
        }

        public void update_totalPrice()
        {
            decimal temp_sum = 0;
            foreach(Product x in currentCart)
            {
                temp_sum = temp_sum + x.Price;
            }
            totalSum = (int)temp_sum;
        }

        //Returns bool if item was found.
        public bool existInCart(int req_P_ID, decimal product_price, int balance)
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
        
        private void addToStatistic(List<Product> currentCart)
        {
            foreach(Product x in currentCart)
            {
                salesStatus.Add(new StatisticProduct(DateTime.Now.ToShortDateString(), x.Name, x.P_ID, x.Balance));
            }
        }
        public void saveProductToStatistic()
        { 
            SH.saveProductsToFile(salesStatus);
        }
        public void loadProductStatistic()
        {
            salesStatus = SH.loadProductsFromFile();
        }
        public List<StatisticProduct> getStatisticList()
        {
            return salesStatus;
        }
        public Product GetProductAtIndex(int index)
        {
            return currentCart.ElementAt(index);
        }

        public void remove(int index)
        {
            if (currentCart.Count > index)
            {
                currentCart.RemoveAt(index);
            }
            update_totalPrice();
        }
        public List<Product> getAllProductsInCart()
        {
            return currentCart;
        }
    }
}
