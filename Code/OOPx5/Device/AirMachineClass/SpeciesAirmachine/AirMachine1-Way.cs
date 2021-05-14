using System;
namespace OOPx5.Device.AirMachineClass.SpeciesAirmachine
{
    public class AirMachine1_Way : AirMachine
    {
        public AirMachine1_Way()
        {
            if (inverter) price = 1500;
            else price = 1000;
        }
        public override void InputDetailBill()
        {
            base.InputDetailBill();
        }

        public override string OutputDetailBill()
        {
            return outPut += $"\tMáy lạnh: {idDevices} loại máy lạnh (1 chiều) {nameDevices} {company} {price * amountSale} {(inverter ? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")} {amountSale}\n";
             
        }
    }
}
