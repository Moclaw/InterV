using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionAirMachine
{
   abstract class AirMachineClass : DevicesClass
    {
        protected bool inverter = false;
        protected int  chooseIverter;
        protected int antimicrobialC;
        protected int odorResistantC;
        protected bool antimicrobial = false;
        protected bool odorResistant = false;
        protected string antimicrobialS;
        protected string odorResistantS;
        protected string inverterS;
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
