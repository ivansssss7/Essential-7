
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Essential7_3
{
    struct Notebook
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public Notebook(string model, string manufacturer, int price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;

        }
        public void Show()
        {
            Console.WriteLine(Model);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Price);
        }
    }
    class Program
    {
        static void Main()
        {
            Notebook notebook = new Notebook("Superbook","Asus",780);

            notebook.Show();

            Console.ReadKey();
        }
    }
}