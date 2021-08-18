using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C968_Project
{
    static class Program
    {
        static void Main()
        {
            InHousePart body = new InHousePart(0, "Body", 19.99m, 8, 2, 50, 3);
            OSPart bridge = new OSPart(1, "Bridge", 9.99m, 2, 1, 25, "Tune-O-Matic");
            InHousePart neck = new InHousePart(2, "Neck", 24.99m, 7, 3, 30, 42);
            OSPart tuner = new OSPart(3, "Tuners", 2.99m, 16, 4, 100, "Gibson");

            Product guitar = new Product(0, "Guitar", 149.99m, 10, 5, 30);
            Product bass = new Product(1, "Bass Guitar", 129.99m, 8, 5, 15);
            Product uke = new Product(2, "Ukulele", 49.99m, 16, 10, 35);

            Inventory.AllParts.Add(body);
            Inventory.AllParts.Add(bridge);
            Inventory.AllParts.Add(neck);
            Inventory.AllParts.Add(tuner);

            Inventory.Products.Add(guitar);
            Inventory.Products.Add(bass);
            Inventory.Products.Add(uke);

            guitar.AssociatedParts.Add(body);
            guitar.AssociatedParts.Add(neck);
            guitar.AssociatedParts.Add(bridge);
            guitar.AssociatedParts.Add(tuner);

            bass.AssociatedParts.Add(body);
            bass.AssociatedParts.Add(neck);
            bass.AssociatedParts.Add(bridge);
            bass.AssociatedParts.Add(tuner);

            uke.AssociatedParts.Add(body);
            uke.AssociatedParts.Add(neck);
            uke.AssociatedParts.Add(bridge);
            uke.AssociatedParts.Add(tuner);








            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
