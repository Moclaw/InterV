using System;

namespace OOP
{

    class Bill  
    {
        private string id { get; set; } //tính đóng gói
        private int day { get; set; }
        private int mounth { get; set; }
        private int year { get; set; }
        public  void InputBill()
        {
            Console.Write("Ma hoa don: ");
            id = Console.ReadLine();

            Console.Write("Ngay lap: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Thang lap: ");
            mounth = int.Parse(Console.ReadLine());

            Console.Write("Nam lap: ");
            year = int.Parse(Console.ReadLine());
        }
        public string BilltoString() => $"Hoa Don: " +
            $"{id}\t" +
            $"{day,2}/" +
            $"{mounth,2}/" +
            $"{year,4}\n";
        
    }
}
