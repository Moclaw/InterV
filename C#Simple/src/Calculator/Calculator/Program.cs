using System;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        { 
        string Phep_tinh;
            double c;
            Encoding utf8 = Encoding.UTF8;
            Console.WriteLine("**************************");
            Console.WriteLine("*     May Tinh Co Ban    *");
            Console.WriteLine("**************************");
            Console.Write("Chon phep tinh: cong, tru, nhanh, chia: ");
            Phep_tinh = Console.ReadLine();
            Console.Write("Nhap so A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so B = ");
            int b = int.Parse(Console.ReadLine());
            if (Phep_tinh == "cong")
            {
                c = a + b;
                Console.WriteLine("Ket qua cua: {0} + {1} = {2}", a, b, c);
            }
            else if (Phep_tinh == "tru")
            {
                c = a - b;
                Console.WriteLine("Ket qua cua: {0} - {1} = {2}", a, b, c);
            }

            else if (Phep_tinh == "nhan")
            {
                c = a * b;
                Console.WriteLine("Ket qua cua: {0} x {1} = {2}", a, b, c);
            }
            else if (Phep_tinh == "chia")
            {

                c = (double)a / b;
                Console.WriteLine("Ket qua cua: {0} : {1} = {2}", a, b, Math.Round(c, 2));
            }
            else
            {
                Console.WriteLine("Lua chon cua ban khong co trong cac truong hop tren!");

            }
            Console.ReadKey();
        }
    }
}
