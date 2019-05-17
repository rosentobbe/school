using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace MediaIntegrator
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcherSimple = new FileSystemWatcher();
            FileSystemWatcher watcherMedia = new FileSystemWatcher();

            folderCheck();

            watcherSimple.Path = AppDomain.CurrentDomain.BaseDirectory + "/frSimpleMedia";
            watcherMedia.Path = AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop";

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcherSimple.NotifyFilter = NotifyFilters.LastAccess
                        | NotifyFilters.LastWrite
                        | NotifyFilters.FileName
                        | NotifyFilters.DirectoryName;
            watcherMedia.NotifyFilter = NotifyFilters.LastAccess
                                    | NotifyFilters.LastWrite
                                    | NotifyFilters.FileName
                                    | NotifyFilters.DirectoryName;

            // Only watch specific XML and CSV-file
            watcherSimple.Filter = "simplemedia.xml";
            watcherMedia.Filter = "ProductsForStore.csv";

            // Add event handlers for file creation.
            watcherSimple.Created += OnChanged;
            watcherMedia.Created += OnChanged;

            // Begin watching.
            watcherSimple.EnableRaisingEvents = true;
            watcherMedia.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine("Press 'q' & 'Enter' to quit the MediaIntegrator.");
            while (Console.Read() != 'q') ;

        }

        //Checks if the folders neeeded exists. If not, then it creates the required folders.
        private static void folderCheck()
        {
            //ExportFolders
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop"))
            {
                Console.WriteLine("in /frMediaShop");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop");
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/frSimpleMedia"))
            {
                Console.WriteLine("in /frSimpleMedia");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/frSimpleMedia");
            }

            //ImportFolders
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/tillMediaShop"))
            {
                Console.WriteLine("in /tillMediaShop");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/tillMediaShop");
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/tillSimpleMedia"))
            {
                Console.WriteLine("in /tillSimpleMedia");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/tillSimpleMedia");
            }
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(500);
            // Specify what is done when a file is created
            if (e.Name == "ProductsForStore.csv" && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop/ProductsForStore.csv"))
            {
                WriteFunctionToXML(Loadcsv());
            }
            else if(e.Name == "simplemedia.xml" && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/frSimpleMedia/simplemedia.xml"))
            {
                WriteFunctionToCSV(LoadXML());
            }

        }

        //Loads all products in the CSV-file found in ProductsForStore.csv and stores it in a List. 
        private static List<string[]> Loadcsv()
        {
            List<string[]> LoadedProducts = new List<string[]>();
            using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop/ProductsForStore.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    LoadedProducts.Add(new string[] { values[0], values[1], values[2], values[3] });
                }
                reader.Close();
            }
            return LoadedProducts;
        }

        //Loads all products in the XML-file found in simplemedia.xml and stores it in a List. 
        private static List<string[]> LoadXML()
        {
            List<string[]> LoadedProducts = new List<string[]>();
            XmlReaderSettings settings = new XmlReaderSettings();
            List<string> triggerWords = new List<string>() { "Name", "Count", "Price", "ProductID" };
            settings.DtdProcessing = DtdProcessing.Parse;
            string path = AppDomain.CurrentDomain.BaseDirectory + "/frSimpleMedia/simplemedia.xml";
            XmlReader reader = XmlReader.Create(path, settings);
            reader.MoveToContent();
            string[] tempString = new string[4];
            string EntityRef = "";
            int count = 0;

            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Item")
                        {
                            tempString = new string[4];
                            count = 0;
                        }
                        EntityRef = reader.Name;
                        break;
                    case XmlNodeType.Text:
                        if (triggerWords.Contains(EntityRef))
                        {
                            tempString[count] = reader.Value;
                            if (tempString[count].Contains(';'))
                            {
                                Console.WriteLine(tempString[count]);
                                tempString[count] = tempString[count].Replace(';', ',');
                                Console.WriteLine(tempString[count]);
                            }
                            count++;
                        }

                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "Item")
                            LoadedProducts.Add(tempString);
                        break;
                }
            }
            reader.Close();
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/frSimpleMedia/simplemedia.xml");
            return LoadedProducts;
        }

        //Writes the content of list to a CSV-file.
        private static void WriteFunctionToCSV(List<string[]> list)
        {
            StringBuilder CsvContent = new StringBuilder();
            string pathToSave = Path.GetFullPath(@"../../../../MediaIntegrator/MediaIntegrator/bin/Debug/tillMediaShop/ProductsForStore.csv");
            foreach (string[] x in list)
            {
                CsvContent.AppendLine(String.Format("{0};{1};{2};{3};", x[3], x[0], x[2], x[1]));
            }
            File.WriteAllText(pathToSave, CsvContent.ToString());
        }

        //Writes the content of productList to a XML-file.
        public static void WriteFunctionToXML(List<string[]> productList)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            XmlWriter writer = XmlWriter.Create(AppDomain.CurrentDomain.BaseDirectory + "/tillSimpleMedia/ProductsMediaShop.xml", settings);

            writer.WriteStartElement("Inventory");
            foreach (string[] x in productList)
            {
                writer.WriteStartElement("Item");

                writer.WriteElementString("Name", x[1]);
                writer.WriteElementString("Count", x[3]);
                writer.WriteElementString("Price", x[2]);
                writer.WriteElementString("Comment", "From MediaStore");
                writer.WriteElementString("Artist", "?");
                writer.WriteElementString("Publisher", "?");
                writer.WriteElementString("Genre", "?");
                writer.WriteElementString("Year", "1");
                writer.WriteElementString("ProductID", x[0]);

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Flush();
            writer.Close();
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop/ProductsForStore.csv");
        }
    }
}
