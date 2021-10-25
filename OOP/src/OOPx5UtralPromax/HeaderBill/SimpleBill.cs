using System;
using OOPx5UtralPromax.Customer;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.HeaderBill
{
    public class SimpleBill
    {
        private string id { get; set; } 
        private string day { get; set; }
        
        public void InputBill()
        {
            Console.Write("Ma hoa don: ");
            id = Console.ReadLine();
            try
            {
                Console.Write("Ngày lập (dd/mm/yyyy vd:01/02/2020): ");
                day = Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
        public string OutputBill()
        {

            return $"Hóa đơn: " +
            $"{id}\t" +
            $"{day}\n";
        }

    }
}