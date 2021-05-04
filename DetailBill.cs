using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DetailBill : DetailBills
    {
        public string IdDevices, Devices, NameDevices, Company, OptionDevices, CoolMachine, DetailsCool1, DetailsCool2;
        public int  WaterCapacity, Amout, Total1, Total2, TotalBill, Electric;
        public override void inputDetailsBill()
        {
            Console.Write("Chon loai thiet bi (1 - may quat,  2 - may lanh): ");
            Devices = Console.ReadLine();
            Console.Write("Nhap ma: ");
            IdDevices = Console.ReadLine();
            Console.Write("Ten san pham: ");
            NameDevices = Console.ReadLine();
            Console.Write("Noi san xuat: ");
            Company = Console.ReadLine();
            Console.Write("So luong ban ra: ");
            Amout = int.Parse(Console.ReadLine());

            if (Devices == "1")
            {
                Devices = "may quat";
                Console.Write("Chon loai quat (1 - may quat dung, 2 - may qua hoi nuoc, 3 - may quat sac dien): ");
                OptionDevices = Console.ReadLine();
                if (OptionDevices == "1")
                {
                    OptionDevices = "May quat dung";
                    Total1 = Amout * 500;
                }
                else if (OptionDevices == "2")
                {
                    OptionDevices = "May quat hoi nuoc";
                    Console.Write("Dung tich nuoc: ");
                    WaterCapacity = int.Parse(Console.ReadLine());
                    Total1 = Amout * (WaterCapacity * 400);
                }
                else if (OptionDevices == "3")
                {
                    OptionDevices = "May quat sac dien";
                    Console.Write("Nhap dung luong pin: ");
                    Electric = int.Parse(Console.ReadLine());
                    Total1 = Amout * (Electric * 500);
                }
            }
            else if (Devices == "2")
            {
                Devices = "may lanh";
                Console.Write("Chon loai may lanh (1 - 1 chieu, 2 - 2 chieu): ");
                OptionDevices = Console.ReadLine();
                if (OptionDevices == "1")
                {
                    OptionDevices = "1 Chieu";
                    Console.Write("Co cong nghe inverter khong (1 - khong co, 2 - co)");
                    CoolMachine = Console.ReadLine();
                    if (CoolMachine == "1")
                    {
                        Total2 = Amout * 1000;
                    }
                    else
                    {
                        Total2 = Amout * 1500;
                    }
                }
                else if (OptionDevices == "2")
                {
                    OptionDevices = "2 Chieu";
                    Console.Write("Co cong nghe inverter khong (1 - khong co, 2 - co)");
                    CoolMachine = Console.ReadLine();
                    if (CoolMachine == "1")
                    {
                        CoolMachine = "Co cong nghe inveter";
                        Console.Write("Co cong nghe khang khuan khong (1 - co, 2 - khong): ");
                        DetailsCool1 = Console.ReadLine();
                        if (DetailsCool1 == "1")
                        {
                            Console.Write("Co cong nghe khu mui khong (1 - co, 2 - khong: ");
                            DetailsCool2 = Console.ReadLine();
                            if (DetailsCool2 == "1")
                            {

                                DetailsCool2 = "Co cong nghe khu mui";
                                Total2 = Amout * 2000 + 1000;
                            }
                            else
                            {

                                DetailsCool2 = "khong co cong nghe khu mui";
                                Total2 = Amout * 2000 + 500;
                            }
                        }
                    }
                    else
                    {
                        CoolMachine = "Khong co cong nghe inveter";
                        Console.Write("Co cong nghe khu mui khong (1 - co, 2 - khong: ");
                        DetailsCool2 = Console.ReadLine();
                        if (DetailsCool2 == "1")
                        {
                            DetailsCool2 = "Co cong nghe khu mui";
                            Total2 = Amout * 2500 + 1000;
                        }
                        else
                        {

                            DetailsCool2 = "khong co cong nghe khu mui";
                            Total2 = Amout * 2500;
                        }
                    }
                }
               
                TotalBill = Total1 + Total2;
            }
        }
        public string outputDetailsBilltoString()
        {
            if (Devices == "may quat")
            {
                return $"May quat: {IdDevices}\t{OptionDevices}\t{NameDevices}\t{Company}\t{Total1}\t{Electric}\t{WaterCapacity}\t{Amout}\n\nTong don: {TotalBill}";
            }
            else
            {
                return $"May quat: {IdDevices}\t{OptionDevices}\t{NameDevices}\t{Total2}\t{CoolMachine}\t{DetailsCool1}\t{DetailsCool2}\t{Amout}\n\nTong don: {TotalBill}";
            }
        }
    }
}
