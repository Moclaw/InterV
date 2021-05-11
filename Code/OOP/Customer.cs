using System;
namespace OOP
{
    abstract class Customers
    {
        public string IdCustomer { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public double Phone { get; set; }
        public abstract void InputInfor();
        public abstract string OutpuntInfortoString();
    }
    class Customer : Customers
    {
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
        public override string OutpuntInfortoString() => $"Thong tin khach hang: " +
            $"{IdCustomer}\t" +
            $"{Name}\t" +
            $"{Address}\t" +
            $"{Phone}\n";
    }
}
