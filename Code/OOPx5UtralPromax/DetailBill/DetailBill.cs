using OOPx5UtralPromax.Devices.OptionFan.SpeciesFan;
using OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine;
using OOPx5UtralPromax.Devices;
using System;

namespace OOPx5UtralPromax.DetailBills
{
    public class DetailBill
    {
        private DevicesClass devices;
        private int chooseDevice;

        public int chooseIverter { get; private set; }
        public int chooseFan { get; private set; }
        public int chooseWay { get; private set; }

        public void InputDetailBill()
        {
            do
            {
                int chooseDevice = 0;
                Console.Write("Chọn loại thiết bị điện(1-máy quạt, 2- máy lạnh): ");
                try
                {
                    chooseDevice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    chooseDevice = -1;
                }

                if (chooseDevice != 2 && chooseDevice != 1)
                {
                    Console.Write("Nhap lai: ");
                }
                switch (chooseDevice)
                {
                    case 1:
                        Console.Write("Chọn loại máy quạt(1 - máy quạt đứng, 2 - máy quạt hơi nước, 3 – máy quạt sạc điện): ");
                        chooseFan = int.Parse(Console.ReadLine());

                        switch (chooseFan)
                        {
                            case 1:
                                devices = new StandFan();
                                devices.InputDetailBill();
                                devices.OutputDetailBill();
                                break;
                            case 2:
                                devices = new SteamFan();
                                devices.InputDetailBill();
                                devices.OutputDetailBill();
                                break;
                            case 3:
                                devices = new BatteryFan();
                                devices.InputDetailBill();

                                devices.OutputDetailBill();
                                break;
                        }
                        break;
                       
                    case 2:
                        Console.Write("Chọn loại máy lạnh (1 -máy lạnh một chiều, 2- máy lạnh hai chiều): ");
                        chooseWay = int.Parse(Console.ReadLine());
                        switch (chooseWay)
                        {
                            case 1:
                                devices = new AirMachine1_Way();
                                devices.InputDetailBill();
                                         devices.OutputDetailBill();
                                break;
                            case 2:
                                devices = new AirMachine2_Way();
                                devices.InputDetailBill();
                                devices.OutputDetailBill();
                                break;
                        }
                        break;
                }

            } while (chooseDevice < 0);

        }


        public double GetTotolBill()
        {
            return devices.AmountSale * devices.Price;
        }
        public string GetData()
        {
            return devices.OutputDetailBill();
        }
    }
}

