using System;
namespace OOP
{
    abstract class Customers // tinh trừu tượng
    {
        protected string idCustomer { get; set; }
        protected string address { get; set; }
        protected string name { get; set; }
        protected double phone { get; set; }
        public abstract void InputInfor();
        public abstract string OutpuntInfortoString();
    }
    class Customer : Customers
    {
        public override void InputInfor()
        {
            Console.Write("Ma khach hang: ");
            idCustomer = Console.ReadLine();

            Console.Write("Ten khach hang: ");
            name = Console.ReadLine();

            Console.Write("Dia chi: ");
            address = Console.ReadLine();

            Console.Write("So dien thoai: ");
            phone = double.Parse(Console.ReadLine());
        }
        public override string OutpuntInfortoString() => $"Thong tin khach hang: " +
            $"{idCustomer}\t" +
            $"{name}\t" +
            $"{address}\t" +
            $"{phone}\n";
    }
}
