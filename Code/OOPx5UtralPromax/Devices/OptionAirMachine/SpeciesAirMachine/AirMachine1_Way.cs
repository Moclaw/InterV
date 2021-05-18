using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionAirMachine.SpeciesAirMachine
{
    class AirMachine1_Way : AirMachineClass
    {
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
                Console.Write("Số lượng bán ra: ");

                amountSale = (int)double.Parse(Console.ReadLine());

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
                $"Tổng giá: {this.price * amountSale}\n" +
                $"{(inverter ? "có hỗ trợ công nghệ inverter" : "không hỗ trợ công nghệ inverter")}\n" +
                $"{ (antimicrobial ? "có công nghệ kháng khuẩn" : "không có công nghệ kháng khuẩn")}\n"+
                $"{ (odorResistant ? "có công nghệ khử mùi" : "không có công nghệ khử mùi")}\n" +
                $"Số lượng: {this.AmountSale}\n";
        }
    }
}
