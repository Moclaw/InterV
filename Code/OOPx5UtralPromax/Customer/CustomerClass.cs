using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Users
{
   public class CustomerClass
    {

        private string idCustomer { get; set; }
        private string address { get; set; }
        private string name { get; set; }
        private double phone { get; set; }

        public string IdCustomer
        {
            get
            {
                return idCustomer;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Phone
        {
            get
            {
                return phone;
            }
        }

        public void InputInfor()
        {
            Console.Write("Ma khach hang: ");
            idCustomer = Console.ReadLine();
            Console.Write("Ten khach hang: ");
            name = Console.ReadLine();
            Console.Write("Dia chi: ");
            address = Console.ReadLine();
            Console.Write("So dien thoai: ");
            try
            {
                phone = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
       
    }
}

