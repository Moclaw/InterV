using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Bill : Bills
    {
        public string IdCustomer, Address, Name, ID;
        public double Phone;
        public int day, mounth, year;
        public override void InputBill()
        {
            Console.Write("Ma hoa don: ");
            ID = Console.ReadLine();
            Console.Write("Ngay lap: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Thang lap: ");
            mounth = int.Parse(Console.ReadLine());
            Console.Write("Nam lap: ");
            year = int.Parse(Console.ReadLine());
        }

        public override void InputInfor()
        {

            Console.Write("Ma khach hang: ");
            IdCustomer = Console.ReadLine();
            Console.Write("Ten khach hang: ");
            Name = Console.ReadLine();
            Console.Write("Dia chi: ");
            Address = Console.ReadLine();
            Console.Write("So dien thoai: ");
            Phone = double.Parse(Console.ReadLine());
        }
        public string BilltoString() => $"Hoa Don: {ID}\t{day}/{mounth}/{year}\n";
        public string InfortoString() => $"Thong tin khach hang: {IdCustomer}\t{Name}\t{Address}\t{Phone}\n";
    }
}
