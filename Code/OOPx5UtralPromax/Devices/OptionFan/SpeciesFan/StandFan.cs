using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionFan.SpeciesFan
{
    class StandFan : FanClass
    {
        public StandFan()
        {
            price = 500;
            Console.Write("Số lượng bán ra: ");

            amountSale = (int)double.Parse(Console.ReadLine());
        }

        public override string OutputDetailBill()
        {
            return outPut += $"\tMáy quạt: {idDevices} " +
                $"Loại máy quạt (quạt đứng) {nameDevices} {company} " +
                $"{this.price * amountSale} {amountSale}\n";
        }
    }
}
