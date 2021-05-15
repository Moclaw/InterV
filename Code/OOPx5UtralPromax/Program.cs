using OOPx5UtralPromax.HeaderBill;
using System;
using System.Text;

namespace OOPx5UtralPromax
{
    class Program
    {
        public static SimpleBill[] SimpleBill { get; private set; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int i,c,_i;
            int n = 0;
            string outputData = "";
            Console.Write("Số lượng hóa đơn muốn nhập: ");
            try
            {
                n = int.Parse(Console.ReadLine());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            SimpleBill = new SimpleBill[n];
            for (i = 0; i < n; i++)
            {
                SimpleBill[i] = new SimpleBill();
                _i = i;
                Console.WriteLine($"Nhập thông tin hóa đơn {++_i}: ");
                SimpleBill[i].InputBill();
                Console.Write($"Thông tin chi tiết của đơn {++_i}: ");
            }
            for (c = 0; i < n; i++)
            {
                {
                    outputData += SimpleBill[c].OutputBill();
                    Console.WriteLine(outputData);
                }
            }
        }
    } 
}
