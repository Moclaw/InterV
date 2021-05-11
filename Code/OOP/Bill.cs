using System;

namespace OOP
{
    class Bills // lớp cơ sở của Bill
    {
        public string ID { get; set; } //tính đóng gói
        public int Day { get; set; }
        public int Mounth { get; set; }
        public int Year { get; set; }
    }


    class Bill : Bills // tính kế thừa
    {
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
