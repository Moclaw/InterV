using System;
namespace OOPx5.Device
{
    public abstract class AirMachine : DevicesClass
    {
        protected bool inverter = false;
        public override void InputDetailBill()
        {
            Console.Write("\t\t\tMáy có hỗ trợ công nghệ inverter không (0 - không, 1 - có): ");
            int inverter_int = int.Parse(Console.ReadLine());
            if (inverter_int == 1) inverter = true;
            base.InputDetailBill();
        }
    }
}
