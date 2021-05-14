using System;
namespace OOPx5.Device.AirMachineClass.SpeciesAirmachine
{
    public class AirMachine2_Way : AirMachine
    {
        private bool antimicrobial;
        private bool deodorant;
        public AirMachine2_Way()
        {
            if (inverter) price = 2500;
            else price = 2000;
        }
        public override void InputDetailBill()
        {
            base.InputDetailBill();
            Console.WriteLine("Có sử dụng công nghệ khử khuẩn không(0 - không, 1 - có): ");
            int antimicrobial_int = int.Parse(Console.ReadLine());
            try
            {
                if (antimicrobial_int == 1)
                {
                    price += 500;
                    antimicrobial = true;
                }

                Console.WriteLine("Có sử dụng công nghệ khử mùi không(0 - không, 1 - có): ");
                int deodorant_int = int.Parse(Console.ReadLine());
                if (Int32.Parse(Console.ReadLine()) == 1)
                {
                    price += 500;
                    deodorant = true;
                }
            }
            catch (Exception e)
            {
                Environment.Exit(0);
            }

        }
        public override string OutputDetailBill()
        {
            return outPut += $"\tMáy lạnh: {idDevices} loại máy lạnh (1 chiều) {nameDevices} {company} {price * amountSale} {(inverter ? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")} " +
                 $"{(antimicrobial ? "có công nghệ kháng khuẩn" : "không có công nghệ kháng khuẩn")} {(deodorant ? "có công nghệ khử mùi" : "không có công nghệ khử mùi")} {amountSale}\n";
        }
    }
}
