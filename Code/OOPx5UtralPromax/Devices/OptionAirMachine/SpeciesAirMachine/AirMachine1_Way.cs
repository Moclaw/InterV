using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine
{
    class AirMachine1_Way : AirMachineClass
    {
        private string inverterS;
        public AirMachine1_Way()
        {
            if (inverter)
            {
                price = 1500;
            }
            price = 1000;
        }
        public override void InputDetailBill()
        {
            base.InputDetailBill();
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
            return outputAir += $"Máy lạnh: {idDevices} loại máy lạnh (1 chiều) " +
                $"{nameDevices} {company} {price * amountSale} " +
                $"{inverterS}" +
                $" {amountSale}\n";
        }
    }
}
