using System;
namespace OOPx5.Device.FanClass.SpeciesFan
{
    public class StandFan : Fan
    {
        public StandFan()
        {
            price = 500;
        }
        public override void InputDetailBill()
        {
            base.InputDetailBill();
        }
        public override string OutputDetailBill()
        {
            outPut += $"\tMáy quạt: {idDevices} Loại máy quạt (quạt đứng) {nameDevices} {company} {price * amountSale} {amountSale}\n";
            return outPut;
        }
    }
}
