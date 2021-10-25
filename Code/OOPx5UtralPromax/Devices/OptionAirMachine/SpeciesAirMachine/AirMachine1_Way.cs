using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine
{
    class AirMachine1_Way : AirMachineClass
    {
        public AirMachine1_Way()
        {
            if (inverter == true)
            {
                price = 1000;
            }
           else price = 1500;
           
        }
        public override void InputDetailBill()
        {
          
            Console.Write("Có sử dụng công nghệ kháng khuẩn không(0 - không, 1 - có): ");
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
                base.InputDetailBill();
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
        public override string OutputDetailBill()
        {
            return $"Máy lạnh: {idDevices} loại máy lạnh (1 chiều)\n" +
                $"Tên thiết bị: {nameDevices}\n" +
                $"Tên công ty sản xuất: {company}\n" +
                $"{(inverter ? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")}\n" +
                $"{ (antimicrobial ? "có công nghệ kháng khuẩn" : "không có công nghệ kháng khuẩn")}\n"+
                $"{ (odorResistant ? "có công nghệ khử mùi" : "không có công nghệ khử mùi")}\n" +
                $"Số lượng: {amountSale}\n"+
                $"Tổng giá: {price * amountSale}\n" +
                $"==================================================\n";
        }
    }
}
