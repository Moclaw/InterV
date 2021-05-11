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
        public string IdDevices { get; set; }
        public string Devices { get; set; }
        public string NameDevices { get; set; }
        public string Company { get; set; }
        public string OptionDevices { get; set; }
        public string CoolMachine { get; set; }
        public string DetailsCool1 { get; set; }
        public string DetailsCool2 { get; set; }
        public int WaterCapacity { get; set; }
        public int Amout { get; set; }
        public int Total1 { get; set; }
        public int Total2 { get; set; }
        public int TotalBill { get; set; }
        public int Electric { get; set; }
    }
    class DetailBill : Parameter, IDetailBill
    {
        readonly Way way = new Way();
        AirMachine airMachine = new AirMachine();
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
                         $"{TotalBill}";
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
                        $"{TotalBill}";
            }
        }


    }
    class Way : Parameter
    {
        public void IntputWay()
        {
            Console.Write("So luong: ");
            Amout = int.Parse(Console.ReadLine());
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
        public int Bien()
        {
            return Total1;
        }
    }

    class AirMachine : Parameter
    {
        public void InputAir()
        {
            Console.Write("So luong: ");
            Amout = int.Parse(Console.ReadLine());
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
            }
        public int Bien2()
        {
            return Total2;
        }
        }
      
    }
    