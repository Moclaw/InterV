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
        protected internal string idDevices { get; set; } //tính đóng gói
        protected internal string devices { get; set; }
        protected internal string nameDevices { get; set; }
        protected internal string company { get; set; }
        protected internal int optionDevices { get; set; }
        protected internal string coolMachine { get; set; }
        protected internal string detailsCool1 { get; set; }
        protected internal string detailsCool2 { get; set; }
        protected int waterCapacity { get; set; }
        protected int amout { get; set; }
        protected int total1 { get; set; }
        protected int total2 { get; set; }
        protected int totalBill { get; set; }
        protected int electric { get; set; }
    }
}

