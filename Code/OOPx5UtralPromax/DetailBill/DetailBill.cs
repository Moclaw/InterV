using OOPx5UtralPromax.Devices.OptionFan.SpeciesFan;
using OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.DetailBill
{
    public class DetailBill
    {
        private Devices.DevicesClass devices;
        private int chooseDevice;
        private int chooseFan;
        public void InputDetailBill()
        {
            Console.Write("Chọn loại thiết bị điện(1-máy quạt, 2- máy lạnh): ");
            try
            {
                chooseDevice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.Exit(0);
            }
            do
            {
                DetailBill detailBill = new DetailBill();
                if (chooseDevice == 1)
                {
                 
                    detailBill.ChooseDeviceFan();
                    break;
                }
                else if (chooseDevice == 2)
                {
                    detailBill.ChooseDeviceAirmachine();
                }
            } while (chooseDevice <=0);
         }


        public void ChooseDeviceFan()
        {
            Console.Write("Chọn loại máy quạt(1 - máy quạt đứng, 2 - máy quạt hơi nước, 3 – máy quạt sạc điện): ");
            try
            {
                chooseFan = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            } 
            do
            {
                if (chooseFan == 1)
                {
                    devices = new StandFan();
                    break;
                }
                else if (chooseFan == 2)
                {
                    devices = new SteamFan();
                    break;
                }
                else if (chooseFan == 3)
                {
                    devices = new BatteryFan(); 
                }
            } while (chooseFan >= 0);
        }

        public void ChooseDeviceAirmachine()
        {

        }
    }
}
