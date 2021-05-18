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
        public override void InputDetailBill()
        {
            base.InputDetailBill();
        }
        public override string OutputDetailBill()
        {
            return $"Máy quạt: {idDevices} " +
                $"Loại máy quạt (quạt đứng)\n" +
                $"Tên thiết bị: {nameDevices}\n" +
                $"Tên công ti sản xuất: {company}\n" +
                $"Tổng giá: {this.price * amountSale}\n" +
                $"Số lượng {amountSale}\n" +
                $"==================================================\n";
        }
    }
}
