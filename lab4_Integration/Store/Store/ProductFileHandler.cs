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
        //Saves the all the products in the store to a CSV-file. 
        //Uses global paths so that it will work on "any" computer.
        public bool saveProductsToFile(List<Product> products, bool exportToSimple = false)
        {
            try
            {
                string pathToSave;
                if (exportToSimple)
                    pathToSave = Path.GetFullPath(@"../../../../MediaIntegrator/MediaIntegrator/bin/Debug/frMediaShop/ProductsForStore.csv");
                else
                    pathToSave = AppDomain.CurrentDomain.BaseDirectory + "ProductsForStore.csv";
                StringBuilder CsvContent = new StringBuilder();
                foreach (Product x in products)
                {
                    CsvContent.AppendLine(String.Format("{0};{1};{2};{3}", x.P_ID, x.Name, x.Price, x.Balance));
                }
                File.WriteAllText(pathToSave, CsvContent.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Loads the products from a CSV-file(if it exists).
        public List<Product> loadProductsFromFile(bool importSimple = false)
        {
            List<Product> LoadedProducts = new List<Product>();

            string pathToLoad;
            if (importSimple)
                pathToLoad = Path.GetFullPath(@"../../../../MediaIntegrator/MediaIntegrator/bin/Debug/tillMediaShop/ProductsForStore.csv");
            else
                pathToLoad = AppDomain.CurrentDomain.BaseDirectory + "ProductsForStore.csv";

            if (File.Exists(pathToLoad))
            {
                using (var reader = new StreamReader(pathToLoad))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        LoadedProducts.Add(new Product(values[1], Convert.ToInt32(values[0]), Convert.ToDecimal(values[2]), Convert.ToInt32(values[3])));
                    }
                }
            }
            return LoadedProducts;
        }

    }
}
