using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionAirMachine
{
   abstract class AirMachineClass : DevicesClass
    {
        protected bool inverter = false;
        private int  chooseIverter;
        protected string outputAir = "";
        public override void InputDetailBill()
        {
            Console.Write("Máy có hỗ trợ công nghệ inverter không (0 - không, 1 - có): ");
            chooseIverter = int.Parse(Console.ReadLine());
            if (chooseIverter == 0)
            {
                inverter = true;
            }
            base.InputDetailBill();
        }
    }
}
