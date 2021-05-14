using System;
namespace OOPx5.DetailBill
{
    class DetaillBill
    {
        private Device.DevicesClass device;
        public void ChooseDevices()
        {
            bool trueChoose = true;
            do
            {
                Console.WriteLine("Chọn loại thiết bị điện(1-máy quạt, 2- máy lạnh): ");
                int choose_int;
                try
                {
                    choose_int = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                switch (choose_int = 0)
                {
                    case 1:
                        ChooseDevices();
                        trueChoose = true;
                        break;
                    case 2:
                        ChooseDevices();
                        trueChoose = true;
                        break;
                    default:
                        Console.WriteLine("Không đúng loại xin chọn lại");
                        choose_int = int.Parse(Console.ReadLine());
                        trueChoose = false;
                        break;
                }
            } while (trueChoose);
            device.InputDetailBill();
            Console.WriteLine("So luong ban ra: ");
            device.AmountSale = int.Parse(Console.ReadLine());
        }
        private void ChooseFan(int chooseFan_int)
        {
            bool chooseFan = true;
            Console.WriteLine("Chọn loại máy quạt(1 - máy quạt đứng, 2 - máy quạt hơi nước, 3 – máy quạt sạc điện): ");
            try
            {
               chooseFan_int = Int32.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            do
            {
                if (chooseFan_int == 1)
                {
                    device = new Device.FanClass.SpeciesFan.StandFan();
                }
            } while (chooseFan);
        }
    }
}