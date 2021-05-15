using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine
{
    class AirMachine2_Way : AirMachineClass
    {
        private string inverterS;
        private int antimicrobialC;
        private int odorResistantC;
        private bool antimicrobial = false;
        private bool odorResistant = false;
        private string antimicrobialS;
        private string odorResistantS;
        public AirMachine2_Way()
        {
            if (inverter)
            {
                price = 2500;
            }
            price = 2000;
        }
        public override void InputDetailBill()
        {
            base.InputDetailBill();
            Console.WriteLine("Có sử dụng công nghệ kháng khuẩn không(0 - không, 1 - có): ");
            try
            {
                antimicrobialC = int.Parse(Console.ReadLine());
                if (antimicrobialC == 1)
                {
                    price += 500;
                    antimicrobial = true;
                }
                Console.Write("Có sử dụng công nghệ khử mùi không(0 - không, 1 - có): ");
                odorResistantC = int.Parse(Console.ReadLine());
                if (odorResistantC == 1)
                {
                    price += 500;
                    odorResistant = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        public override string OutputDetailBill()
        {
            if (inverter)
            {
                inverterS = "có hỗ trợ công nghệ inverter";
            }
            else
            {
                inverterS = "không có hỗ trợ công nghệ inverter";
            }
            if (antimicrobial)
            {
                antimicrobialS = "có công nghệ kháng khuẩn";
            }
            else
            {
                antimicrobialS = "không có công nghệ kháng khuẩn";
            }
            if (odorResistant)
            {
                odorResistantS = "có công nghệ khử mùi";
            }
            else
            {
                odorResistantS = "không có công nghệ khử mùi";
            }

            return outputAir += $"Máy lạnh: {idDevices} loại máy lạnh (1 chiều) " +
                $"{nameDevices} {company} {price * amountSale} " +
                $"{inverterS}" +
                $"{antimicrobialS} "+
                $"{odorResistantS} "+
                $" {amountSale}\n";
        }
    }
}
