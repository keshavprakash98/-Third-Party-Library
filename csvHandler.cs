using System;
using System.Collections.Generic;
using System.Text;

namespace TPLproject
{
    public class csvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"E:\bridgeLabz\TPLproject\Utility\address.csv";
            string exportFilePath = @"E:\bridgeLabz\TPLproject\Utility\export.csv";

            //reading CSV file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader,CultureInfo.InvarianCulture))
            {
                var record = csv.GetRecord<AddressData>().toList();
                Console.WriteLine("Read data successfully from address csv.");
                foreach (AddressData addressData in record)
                {
                    Console.WriteLine("\t" + addressData.FirstName);
                    Console.WriteLine("\t" + addressData.LastName);
                    Console.WriteLine("\t" + addressData.Address);
                    Console.WriteLine("\t" + addressData.City);
                    Console.WriteLine("\t" + addressData.State);
                    Console.WriteLine("\t" + addressData.Code);

                    Console.WriteLine("\n");


                }
                Console.WriteLine("\n****now reding from csv and write to csv file****");
                //writing csv file
                //using (var writer = new StreamWriter(exportFilePath))
                //using (var csvExport = new CsvWriter(writer,cultureInfo.InvariantCulture))
                //{
                //    csvExport.WriteRecords(record); 
                // }
            }

        }

    }
}
