using System;
using System.IO;
namespace OOP
{
    abstract class Bills
    {
        public abstract void InputBill();
        public abstract void InputInfor();
    }
    abstract class DetailBills
    {
        public abstract void inputDetailsBill();
    }
    class Program
    {
        static void Main()
        {
            string A = "";
            int n;
            Bill[] a = new Bill[100];
            Bill[] b = new Bill[100];
            DetailBill[] c = new DetailBill[100];
            Console.Write("So luong hoa don can nhap: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhap thong tin don {0}", i);
                b[i] = new Bill();
                b[i].InputBill();
                Console.WriteLine("Thong tin khach hang so {0}: ", i);
                a[i] = new Bill();
                a[i].InputInfor();
                Console.WriteLine("Thong tin chi tiet don hang so {0}", i);
                c[i] = new DetailBill();
                c[i].inputDetailsBill();
            }
            for (int i = 1; i <= n; i++)
            {
                A += b[i].BilltoString();
                A += a[i].InfortoString();
                A += c[i].outputDetailsBilltoString();
                Console.WriteLine(A);
            }
            FileStream Mbill = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outputBills = new StreamWriter(Mbill);
            outputBills.WriteLine(A);
            outputBills.Flush();
            Console.WriteLine("File dang_sach_hoa_don.txt da dc xuat ra o desktop");
            Console.ReadKey();
        }
    }
}
