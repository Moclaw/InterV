using System;

namespace OOP
{
    class DetailBill : Parameter, IDetailBill
    {
        Way way = new Way();
        Airmachine airMachine = new Airmachine();
        public void InputDetailBilll()
        {
            Console.Write("Chon loai thiet bi (1 - may quat,  2 - may lanh): ");
            Devices = Console.ReadLine();
            Console.Write("Nhap ma: ");
            IdDevices = Console.ReadLine();
            Console.Write("Ten san pham: ");
            NameDevices = Console.ReadLine();
            Console.Write("Noi san xuat: ");
            Company = Console.ReadLine();
            if (Devices == "1")
            {
                way.IntputWay();

            }
            else
            {
                airMachine.InputAir();

            }
            TotalBill = way.Bien() + airMachine.Bien2();
        }

        public string OutputDetailBill()
        {

            if (Devices == "1")
            {
                return $"May quat: {IdDevices}\t" +
                         $"{OptionDevices}\t" +
                         $"{NameDevices}\t" +
                         $"{Total1}\t" +
                         $"{CoolMachine}\t" +
                         $"{DetailsCool1}\t" +
                         $"{DetailsCool2}\t" +
                         $"{Amout}\n\n" +
                         $"Tong gia: {TotalBill}";
            }
            else
            {
                return $"May lanh: {IdDevices}\t" +
                        $"{OptionDevices}\t" +
                        $"{NameDevices}\t" +
                        $"{Company}\t" +
                        $"{Total2}\t" +
                        $"{Electric}\t" +
                        $"{WaterCapacity}\t" +
                        $"{Amout}\n\n" +
                        $"Tong gia: {TotalBill}";
            }
        }
    }
}
    