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
                    waterCapacity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (waterCapacity <= 0);
            price = waterCapacity * 400;
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
                $"Loại máy quạt (quạt hơi nước)\n" +
                $"Tên thiết bị: {nameDevices}\n" +
                $"Tên công ti sản xuất: {company}\n" +
                $"Tổng giá: {this.price * amountSale}\n" +
                $"Số lượng {amountSale}\n";

        }
    }
}
