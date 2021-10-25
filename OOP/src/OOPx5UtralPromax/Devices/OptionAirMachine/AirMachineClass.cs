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
            Console.Write("Máy có hỗ trợ công nghệ inverter không (0 - không, 1 - có): ");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                inverter = true;
            }
            base.InputDetailBill();
        }
    }
}
