using System;
namespace OOP
{
    interface IDetailBill //tinh da hinh 
    {
        void InputDetailBilll();
        string OutputDetailBill();
    }
    class Parameter
    {
        protected internal string IdDevices { get; set; } //tính đóng gói
        protected internal string Devices { get; set; }
        protected internal string NameDevices { get; set; }
        protected internal string Company { get; set; }
        protected internal string OptionDevices { get; set; }
        protected internal string CoolMachine { get; set; }
        protected internal string DetailsCool1 { get; set; }
        protected internal string DetailsCool2 { get; set; }
        protected int WaterCapacity { get; set; }
        protected int Amout { get; set; }
        protected int Total1 { get; set; }
        protected int Total2 { get; set; }
        protected int TotalBill { get; set; }
        protected int Electric { get; set; }
    }
}

