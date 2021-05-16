using System;
using OOPx5UtralPromax.Customer;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.HeaderBill
{
    public class SimpleBill
    {
        private string id { get; set; } //tính đóng gói
        private int day { get; set; }
        private int mounth { get; set; }
        private int year { get; set; }
        public void InputBill()
        {
            Console.Write("Ma hoa don: ");
            id = Console.ReadLine();
            try
            {
                Console.Write("Ngay lap: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Thang lap: ");
                mounth = int.Parse(Console.ReadLine());
                Console.Write("Nam lap: ");
                year = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
        public string OutputBill()
        {
            string dataHoaDon = "";
            dataHoaDon += $"Hoa Don: " +
            $"{id}\t" +
            $"{day,2}/" +
            $"{mounth,2}/" +
            $"{year,4}\n";
            return dataHoaDon;
        }

    }
}