using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class StatisticHandler
    {
        public bool saveProductsToFile(List<StatisticProduct> statistics)
        {
            try
            {
                StringBuilder CsvContent = new StringBuilder();
                foreach (StatisticProduct x in statistics)
                {
                    CsvContent.AppendLine(String.Format("{0},{1},{2},{3}",x.Date, x.Name, x.P_ID, x.Balance));
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "Salestatus.csv";
                File.WriteAllText(path, CsvContent.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<StatisticProduct> loadProductsFromFile()
        {
            List<StatisticProduct> LoadedProducts = new List<StatisticProduct>();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Salestatus.csv"))
            {
                using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Salestatus.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        LoadedProducts.Add(new StatisticProduct(values[0], values[1], Convert.ToInt32(values[2]), Convert.ToInt32(values[3])));
                    }
                }
            }
            return LoadedProducts;
        }
    }
}
