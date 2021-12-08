 using System;

namespace TPLproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read data from CSV and Write data in CSV");
            //read.write Operation of csv file
            csvHandler.ImplementCSVDataHandling();
            Console.WriteLine();
        }
    }
}
