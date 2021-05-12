using System;

namespace OOP
{
    class DetailBill : Parameter, IDetailBill
    {
        Way way = new Way();
        Airmachine airMachine = new Airmachine();
        public void InputDetailBilll()
        {
            Console.Write("Chon loai thiet bi (1 - may quat,  2 - may lanh): ");
            devices = Console.ReadLine();

            Console.Write("Nhap ma: ");
            idDevices = Console.ReadLine();

            Console.Write("Ten san pham: ");
            nameDevices = Console.ReadLine();

            Console.Write("Noi san xuat: ");
            company = Console.ReadLine();

            if (devices == "1")
            {
                way.IntputWay();

            }
            else
            {
                airMachine.InputAir();

            }
            totalBill = way.Bien() + airMachine.Bien2();
        }

        public string OutputDetailBill()
        {

            if (devices == "1")
            {
                return $"May quat: {idDevices}\t" +
                         $"{optionDevices}\t" +
                         $"{nameDevices}\t" +
                         $"{total1}\t" +
                         $"{coolMachine}\t" +
                         $"{detailsCool1}\t" +
                         $"{detailsCool2}\t" +
                         $"{amout}\n\n" +
                         $"Tong gia: {totalBill}\n";
            }
            else
            {
                return $"May lanh: {idDevices}\t" +
                        $"{optionDevices}\t" +
                        $"{nameDevices}\t" +
                        $"{company}\t" +
                        $"{total2}\t" +
                        $"{electric}\t" +
                        $"{waterCapacity}\t" +
                        $"{amout}\n\n" +
                        $"Tong gia: {totalBill}\n";
            }
        }
    }
}
    