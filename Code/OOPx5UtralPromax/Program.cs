using OOPx5UtralPromax.HeaderBill;
using OOPx5UtralPromax.Customer;
using OOPx5UtralPromax.DetailBills;
using System;
using System.Text;
using System.IO;

namespace OOPx5UtralPromax
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int i,c;
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
           SimpleBill[]  simpleBill = new SimpleBill[100];
           DetailBill[] detailBill = new DetailBill[100];
           CustomerClass[] customer = new CustomerClass[100];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin hóa đơn {++i}: ");
                simpleBill[i] = new SimpleBill();
                simpleBill[i].InputBill();
                Console.Write("Thông tin khách hàng số: ");
                customer[i] = new CustomerClass();
                customer[i].InputInfor();
                Console.Write("Thông tin chi tiết đơn: \n");
                detailBill[i] = new DetailBill();
                detailBill[i].InputDetailBill();
            }
            for (c = 0; i < n; i++)
            {
                    outputData += simpleBill[c].OutputBill();
                    outputData += customer[c].OutputInfor();
                    outputData += detailBill[c].OutputDataDevices();
            }
            FileStream Mbill = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outputBills = new StreamWriter(Mbill);
            outputBills.WriteLine(outputData);
            outputBills.Flush();
            Console.WriteLine("File dang_sach_hoa_don.txt da dc xuat ra o desktop");
            Console.ReadKey();
        }
    } 
}
