using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class StatisticProduct
    {
        public string Date { get; set; }
        public string Name { get; set; }
        public int P_ID { get; set; }
        public int Balance { get; set; }
        public StatisticProduct(string date, string name, int p_id, int balance)
        {
            Date = date;
            Name = name;
            P_ID = p_id;
            Balance = balance;
        }
    }
}
