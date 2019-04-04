using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Product
    {
        public string Name { get; set; }
        public int P_ID { get; set; }
        public decimal Price { get; set; }
        public int Balance { get; set; }
        public Product(string name, int p_id, decimal price, int balance)
        {
            Name = name;
            P_ID = p_id;
            Price = price;
            Balance = balance;
        }
    }
}
