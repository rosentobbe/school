using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Store
{
    class ProductFileHandler
    {
        public bool saveProductsToFile(List<Product> products)
        {
            try
            {
                StringBuilder CsvContent = new StringBuilder();
                foreach (Product x in products)
                {
                    CsvContent.AppendLine(String.Format("{0},{1},{2},{3}", x.P_ID, x.Name, x.Price, x.Balance));
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "ProductsForStore.csv";
                File.WriteAllText(path, CsvContent.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> loadProductsFromFile()
        {
            List<Product> LoadedProducts = new List<Product>();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ProductsForStore.csv"))
            {
                using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "ProductsForStore.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        LoadedProducts.Add(new Product(values[1], Convert.ToInt32(values[0]), Convert.ToDecimal(values[2]), Convert.ToInt32(values[3])));
                    }
                }
            }
            return LoadedProducts;
        }

    }
}
