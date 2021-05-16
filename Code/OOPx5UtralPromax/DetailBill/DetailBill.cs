using OOPx5UtralPromax.Devices.OptionFan.SpeciesFan;
using OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine;
using OOPx5UtralPromax.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.DetailBills
{
    public class DetailBill
    {
        private DevicesClass devices;
        private int chooseDevice;
        private int chooseAirMachine;
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
                    break;
                }

            } while (chooseDevice <= 0);

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
            Console.Write("Chọn loại máy lạnh (1 -máy lạnh một chiều, 2- máy lạnh hai chiều): ");
            try
            {
                chooseAirMachine = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            do
            {
                if (chooseAirMachine == 1)
                {
                    devices = new AirMachine1_Way();
                    break;
                }
                else if (chooseAirMachine == 2)
                {
                    devices = new AirMachine2_Way();
                    break;
                }

            } while (chooseAirMachine >= 0);
        }
        public double GetTotolBill()
        {
            return devices.AmountSale * devices.Price;
        }
        public string GetData()
        {
            string dataThietBi = "";
            dataThietBi += devices.OutputDetailBill();

            return dataThietBi;
        }
    }
}

