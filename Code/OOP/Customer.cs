using System;
namespace OOP
{
    abstract class Customers // tinh trừu tượng
    {
        protected string IdCustomer { get; set; }
        protected string Address { get; set; }
        protected string Name { get; set; }
        protected double Phone { get; set; }
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
