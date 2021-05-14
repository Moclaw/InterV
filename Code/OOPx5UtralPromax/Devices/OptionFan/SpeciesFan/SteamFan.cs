using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionFan.SpeciesFan
{
    class SteamFan: FanClass
    {
        private int waterCapacity { get; set; }
        public SteamFan()
        {
            Console.Write("Dung tich nuoc: ");
            do
            {
                try
                {
                    waterCapacity = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    waterCapacity = -1;
                }

                if (waterCapacity <= 0)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (waterCapacity <= 0);
            price = waterCapacity * 400;
        }
        public override string OutputDetailBill()
        {
            return outPut += $"\tMáy quạt: {idDevices} Loại máy quạt (quạt đứng) {nameDevices} {company} {this.price * amountSale} {amountSale}\n";

        }
    }
}
