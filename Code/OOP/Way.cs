using System;
namespace OOP
{
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
}
