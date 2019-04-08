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
        int totalSum { get; set; }

        List<Product> allProducts = new List<Product>();
        List<Product> currentCart = new List<Product>();

        public void checkout()
        {

        }
        public void clear()
        {

        }


        public void add(int product_ID, string product_Name, decimal product_Price, int balance)
        {
            //här !
        }

        //Returns index if product is in cart.
        public int existInCart(int req_P_ID)
        {
            int index = -1;
            foreach(Product x in currentCart)
            {
                index++;
                if(x.P_ID == req_P_ID)
                    return index;
            }
            return -1;
        }

        public void remove(int index)
        {
            if(currentCart.Count > index)
            currentCart.RemoveAt(index);
        }
        public void viewCart()
        {

        }
    }
}
