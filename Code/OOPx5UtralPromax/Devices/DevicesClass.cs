using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices
{
    abstract class DevicesClass
    {
        protected string idDevices { get; set; }
        protected string devices { get; set; }
        protected string nameDevices { get; set; }
        protected string company { get; set; }
        protected int amountSale { get; set; }
        protected double price { get; set; }
        protected string outPut = "";
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int AmountSale
        {
            get { return amountSale; }
            set { amountSale = value; }
        }

        public virtual void InputDetailBill()
        {
            Console.Write("Nhap ma: ");
            this.idDevices = Console.ReadLine();

            Console.Write("Ten san pham: ");
            this.nameDevices = Console.ReadLine();

            Console.Write("Noi san xuat: ");
            this.company = Console.ReadLine();
        }
        public abstract string OutputDetailBill();
    }
}
