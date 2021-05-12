using System;

namespace OOP
{

    class Bill  
    {
        private string ID { get; set; } //tính đóng gói
        private int Day { get; set; }
        private int Mounth { get; set; }
        private int Year { get; set; }
        public  void InputBill()
        {
            Console.Write("Ma hoa don: ");
            ID = Console.ReadLine();
            Console.Write("Ngay lap: ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Thang lap: ");
            Mounth = int.Parse(Console.ReadLine());
            Console.Write("Nam lap: ");
            Year = int.Parse(Console.ReadLine());
        }
        public string BilltoString() => $"Hoa Don: " +
            $"{ID}\t" +
            $"{Day,2}/" +
            $"{Mounth,2}/" +
            $"{Year,4}\n";
        
    }
}
