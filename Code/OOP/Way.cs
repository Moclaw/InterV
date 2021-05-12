using System;
namespace OOP
{
    class Way : Parameter
    {
        public void IntputWay()
        {
            Console.Write("So luong: ");
            amout = int.Parse(Console.ReadLine());
            Console.Write("Chon loai quat (1 - may quat dung, 2 - may qua hoi nuoc, 3 - may quat sac dien): ");
            optionDevices = int.Parse(Console.ReadLine());
            if (optionDevices == 1)
            {
                total1 = amout * 500;
            }
            else if (optionDevices == 2)
            {
                Console.Write("Dung tich nuoc: ");
                waterCapacity = int.Parse(Console.ReadLine());
                total1 = amout * (waterCapacity * 400);
            }
            else if (optionDevices == 3)
            {
                Console.Write("Nhap dung luong pin: ");
                electric = int.Parse(Console.ReadLine());
                total1 = amout * (electric * 500);
            }
        }
        public int Bien()
        {
            return total1;
        }
    }
}
