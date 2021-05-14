using System;
namespace OOPx5.Device.FanClass.SpeciesFan
{
    public class ElectricFan : Fan
    {
        private int electric{ get; set; }
        public ElectricFan()
        {
            Console.Write("Nhap dung luong pin: ");
            do
            {
                try
                {
                    electric = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    electric = -1;
                }

                if (electric <= 0)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (electric <= 0);
            price = electric*500;
        }

        public override string OutputDetailBill()
        {
            return outPut += $"\tMáy quạt: {idDevices} Loại máy quạt (quạt đứng) {nameDevices} {company} {this.price *amountSale} {amountSale}\n";
             
        }
    }
}
