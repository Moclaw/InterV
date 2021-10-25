using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionFan.SpeciesFan
{
    class BatteryFan : FanClass
    {
        private int batteryCapacity { get; set; }
        public BatteryFan()
        {
            Console.Write("Dung lượng điện: ");
            do
            {
                try
                {
                    batteryCapacity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Nhap lai: ");
                }

                if (batteryCapacity <= 0)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (batteryCapacity <= 0);
            price = batteryCapacity * 500;
            Console.Write("Số lượng bán ra: ");

            amountSale = (int)double.Parse(Console.ReadLine());

        }
        public override void InputDetailBill()
        {
            base.InputDetailBill();
        }
        public override string OutputDetailBill()
        {
            return $"Máy quạt: {idDevices} " +
                $"Loại máy quạt (quạt sạc điện)\n" +
                $"Tên thiết bị: {nameDevices}\n" +
                $"Tên công ti sản xuất: {company}\n" +
                $"Tổng giá: {this.price * amountSale}\n" +
                $"Số lượng {amountSale}\n" +
                $"==================================================\n";

        }
    }
}
