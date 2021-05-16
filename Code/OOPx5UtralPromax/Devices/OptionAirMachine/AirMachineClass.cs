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
           
            if (chooseIverter == 0)
            {
                inverter = true;
            }
            base.InputDetailBill();
        }
    }
}
