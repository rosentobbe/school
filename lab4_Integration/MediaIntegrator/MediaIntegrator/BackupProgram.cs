//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MediaIntegrator
//{
//    class BackupProgram
//    {
//        public static void Main(string[] args)
//        {

//            // Create a new FileSystemWatcher and set its properties.
//            using (FileSystemWatcher watcher = new FileSystemWatcher())
//            {
//                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop"))
//                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop");

//                watcher.Path = Path.GetFullPath(@"../../../../Store/Store/bin/Debug/");

//                // Watch for changes in LastAccess and LastWrite times, and
//                // the renaming of files or directories.
//                watcher.NotifyFilter = NotifyFilters.LastAccess
//                                     | NotifyFilters.LastWrite
//                                     | NotifyFilters.FileName
//                                     | NotifyFilters.DirectoryName;

//                // Only watch text files.
//                watcher.Filter = "ProductsForStore.csv";

//                // Add event handlers.
//                watcher.Changed += OnChanged;
//                watcher.Created += OnChanged;
//                watcher.Deleted += OnChanged; //Behövs ej? TODO
//                watcher.Renamed += OnRenamed; //Behövs ej? TODO

//                // Begin watching.
//                watcher.EnableRaisingEvents = true;

//                Console.WriteLine("Before");

//                Console.WriteLine("After");

//                // Wait for the user to quit the program.
//                Console.WriteLine("Press 'q' to quit the sample.");
//                while (Console.Read() != 'q') ;
//            }

//        }

//        // Define the event handlers.
//        private static void OnChanged(object source, FileSystemEventArgs e)
//        {
//            // Specify what is done when a file is changed, created, or deleted.
//            WriteFunction(Loadcsv());
//            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

//        }

//        private static void OnRenamed(object source, RenamedEventArgs e)
//        {
//            // Specify what is done when a file is renamed.
//            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
//        }

//        private static List<string[]> Loadcsv()
//        {
//            List<string[]> LoadedProducts = new List<string[]>();
//            using (var reader = new StreamReader(Path.GetFullPath(@"../../../../Store/Store/bin/Debug/ProductsForStore.csv")))
//            {
//                while (!reader.EndOfStream)
//                {
//                    var line = reader.ReadLine();
//                    var values = line.Split(',');
//                    LoadedProducts.Add(new string[] { values[0], values[1], values[2], values[3] });
//                }
//            }
//            return LoadedProducts;
//        }

//        public static void WriteFunction(List<string[]> productList)
//        {
//            XmlWriterSettings settings = new XmlWriterSettings();
//            settings.Indent = true;
//            settings.IndentChars = "\t";
//            XmlWriter writer = XmlWriter.Create(AppDomain.CurrentDomain.BaseDirectory + "/frMediaShop/ProductsMediaShop.xml", settings);

//            writer.WriteStartElement("Inventory");
//            foreach (string[] x in productList)
//            {
//                writer.WriteStartElement("Item");

//                writer.WriteElementString("Name", x[1]);
//                writer.WriteElementString("Count", x[3]);
//                writer.WriteElementString("Price", x[2]);
//                writer.WriteElementString("Comment", "From MediaStore");
//                writer.WriteElementString("Artist", "?");
//                writer.WriteElementString("Publisher", "?");
//                writer.WriteElementString("Genre", "?");
//                writer.WriteElementString("Year", "1");
//                writer.WriteElementString("ProductID", x[0]);

//                writer.WriteEndElement();
//            }

//            writer.WriteEndElement();

//            writer.Flush();
//        }
//    }
//}
