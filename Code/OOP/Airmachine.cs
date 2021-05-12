using System;
namespace OOP
{
    class Airmachine : Parameter
    {
        public void InputAir()
        {
            Console.Write("So luong: ");
            amout = int.Parse(Console.ReadLine());

            Console.Write("Chon loai may lanh (1 - 1 chieu, 2 - 2 chieu): ");
            optionDevices = int.Parse(Console.ReadLine());


            if (optionDevices == 1)
            {
                Console.Write("Co cong nghe inverter khong (0 - khong co, 1 - co)");
                coolMachine = Console.ReadLine();


                if (coolMachine == "1")
                {
                    coolMachine = "Co cong nghe inverter";
                    total2 = amout * 1000;
                }
                else
                {
                    total2 = amout * 1500;
                }
            }
            else if (optionDevices == 0)
            {
                Console.Write("Co cong nghe inverter khong (0 - khong co, 1 - co)");
                coolMachine = Console.ReadLine();


                if (coolMachine == "1")
                {
                    Console.Write("Co cong nghe khang khuan khong (1 - co, 0 - khong): ");
                    detailsCool1 = Console.ReadLine();



                    if (detailsCool1 == "1")
                    {
                        Console.Write("Co cong nghe khu mui khong (1 - co, 2 - khong: ");
                        detailsCool2 = Console.ReadLine();


                        if (detailsCool2 == "1")
                        {

                            detailsCool2 = "Co cong nghe khu mui";
                            total2 = amout * 2000 + 1000;
                        }
                        else
                        {

                            detailsCool2 = "khong co cong nghe khu mui";
                            total2 = amout * 2000 + 500;
                        }
                    }
                }
                else
                {
                    coolMachine = "Khong co cong nghe inveter";
                    Console.Write("Co cong nghe khu mui khong (1 - co, 2 - khong: ");

                    detailsCool2 = Console.ReadLine();
                    if (detailsCool2 == "1")
                    {
                        detailsCool2 = "Co cong nghe khu mui";
                        total2 = amout * 2500 + 1000;
                    }
                    else
                    {

                        detailsCool2 = "khong co cong nghe khu mui";
                        total2 = amout * 2500;
                    }
                }
            }
        }
        public int Bien2()
        {
            return total2;
        }
    }
}
