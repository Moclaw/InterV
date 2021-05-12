using System;
namespace OOP
{
    class Airmachine : Parameter
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
