using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace oop2
{   
    public class InfoCustomer
    {
        string IdCustomer, Address, Name;
        double Phone;
        //input inforCustomer
        public void InputInfor()
        {
            Console.Write("Ma khach hang: ");
            IdCustomer = Console.ReadLine();
            Console.Write("Ten khach hang: ");
            Name = Console.ReadLine();
            Console.Write("Dia chi: ");
            Address = Console.ReadLine();
            Console.Write("So dien thoai: ");
            Phone = double.Parse(Console.ReadLine());
        }
        public string InfortoString()
        {
            return $"Thong tin khach hang: {IdCustomer}\t{Name}\t{Address}\t{Phone}\n";
        }
        public void OutputInfor()
        {
            Console.Write(InfortoString());

            }
        public class Bill
        {
            int day, mounth, year;
            string ID;
            public void InforBill()
            {
                Console.Write("Ma hoa don: ");
                ID = Console.ReadLine();
                Console.Write("Ngay lap: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Thang lap: ");
                mounth = int.Parse(Console.ReadLine());
                Console.Write("Nam lap: ");
                year = int.Parse(Console.ReadLine());
            }
            public string BilltoString()
            {
                return $"Hoa Don: {ID}\t{day}/{mounth}/{year}\n";
            }
            public void outputBill()
            {
               Console.WriteLine(BilltoString());
            }
        }
        public class DetailsBill
        {
            int WaterCapacity, Amout, Total1, Total2, TotalBill, Electric;
            string IdDevices, Devices, NameDevices, Company, OptionDevices, CoolMachine, DetailsCool1, DetailsCool2;
            public void inputDetailsBill()
            {
                Console.Write("Chon loai thiet bi (1 - may quat,  2 - may lanh): ");
                Devices = Console.ReadLine();
                Console.Write("Nhap ma: ");
                IdDevices = Console.ReadLine();
                Console.Write("Ten san pham: ");
                NameDevices = Console.ReadLine();
                Console.Write("Noi san xuat: ");
                Company = Console.ReadLine();
                Console.Write("So luong ban ra: ");
                Amout = int.Parse(Console.ReadLine());

                if (Devices == "1")
                {
                    Devices = "may quat";
                    Console.Write("Chon loai quat (1 - may quat dung, 2 - may qua hoi nuoc, 3 - may quat sac dien): ");
                    OptionDevices = Console.ReadLine();
                    if (OptionDevices == "1")
                    {
                        OptionDevices = "May quat dung";
                        Total1 = Amout * 500;
                    }
                    else if (OptionDevices == "2")
                    {
                        OptionDevices = "May quat hoi nuoc";
                        Console.Write("Dung tich nuoc: ");
                        WaterCapacity = int.Parse(Console.ReadLine());
                        Total1 = Amout * (WaterCapacity * 400);
                    }
                    else if (OptionDevices == "3")
                    {
                        OptionDevices = "May quat sac dien";
                        Console.Write("Nhap dung luong pin: ");
                        Electric = int.Parse(Console.ReadLine());
                        Total1 = Amout * (Electric * 500);
                    }
                }
                else if (Devices == "2")
                {
                    Devices = "may lanh";
                    Console.Write("Chon loai may lanh (1 - 1 chieu, 2 - 2 chieu): ");
                    OptionDevices = Console.ReadLine();
                    if (OptionDevices == "1")
                    {
                        OptionDevices = "1 Chieu";
                        Console.Write("Co cong nghe inverter khong (1 - khong co, 2 - co)");
                        CoolMachine = Console.ReadLine();
                        if (CoolMachine == "1")
                        {
                            Total2 = Amout * 1000;
                        }
                        else
                        {
                            Total2 = Amout * 1500;
                        }
                    }
                    else if (OptionDevices == "2")
                    {
                        OptionDevices = "2 Chieu";
                        Console.Write("Co cong nghe inverter khong (1 - khong co, 2 - co)");
                        CoolMachine = Console.ReadLine();
                        if (CoolMachine == "1")
                        {
                            CoolMachine = "Co cong nghe inveter";
                            Console.Write("Co cong nghe khang khuan khong (1 - co, 2 - khong): ");
                            DetailsCool1 = Console.ReadLine();
                            if (DetailsCool1 == "1")
                            {
                                Console.Write("Co cong nghe khu mui khong (1 - co, 2 - khong: ");
                                DetailsCool2 = Console.ReadLine();
                                if (DetailsCool2 == "1")
                                {

                                    DetailsCool2 = "Co cong nghe khu mui";
                                    Total2 = Amout * 2000 + 1000;
                                }
                                else
                                {

                                    DetailsCool2 = "khong co cong nghe khu mui";
                                    Total2 = Amout * 2000 + 500;
                                }
                            }
                        }
                        else
                        {
                            CoolMachine = "Khong co cong nghe inveter";
                            Console.Write("Co cong nghe khu mui khong (1 - co, 2 - khong: ");
                            DetailsCool2 = Console.ReadLine();
                            if (DetailsCool2 == "1")
                            {
                                DetailsCool2 = "Co cong nghe khu mui";
                                Total2 = Amout * 2500 + 1000;
                            }
                            else
                            {

                                DetailsCool2 = "khong co cong nghe khu mui";
                                Total2 = Amout * 2500;
                            }
                        }
                    }
                }
            }
            public string outputDetailsBilltoString()
            {

                TotalBill = Total1 + Total2;
                if (Devices == "may quat")
                {
                    return  $"May quat: {IdDevices}\t{OptionDevices}\t{NameDevices}\t{Company}\t{Total1}\t{Electric}\t{WaterCapacity}\t{Amout}\n\n{TotalBill}";
                }
                else
                {
                    return $"May quat: {IdDevices}\t{OptionDevices}\t{NameDevices}\t{Total2}\t{CoolMachine}\t{DetailsCool1}\t{DetailsCool2}\t{Amout}\n\n{TotalBill}";
                }
            }
            public void outputDetailsBill()
            {
                TotalBill = Total1 + Total2;
                //if (Devices == "may quat")
                //{
                //    Console.WriteLine(a);
                //}
                //else
                //{
                //    Console.WriteLine($"May quat: {IdDevices}\t{OptionDevices}\t{NameDevices}\t{Total2}\t{CoolMachine}\t{DetailsCool1}\t{DetailsCool2}\t{Amout}\n");
                //}
                Console.WriteLine("Tong gia: {0}", TotalBill);
            }
        }
        class Program
        {
            public static void Main()
            {
                int n;
                InfoCustomer[] a = new InfoCustomer[100];
                Bill[] b = new Bill[100];
                DetailsBill[] c = new DetailsBill[100];
                Console.Write("So luong hoa don can nhap: ");
                n = int.Parse(Console.ReadLine());

                //Input
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Nhap thong tin don {0}", i);
                    b[i] = new Bill();
                    b[i].InforBill();
                    Console.WriteLine("Thong tin khach hang so {0}: ", i);
                    a[i] = new InfoCustomer();
                    a[i].InputInfor();
                    Console.WriteLine("Thong tin chi tiet don hang so {0}", i);
                    c[i] = new DetailsBill();
                    c[i].inputDetailsBill();
                }
                //output
                string A = "";
    
                FileStream Mbill = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.Create, FileAccess.Write);
                StreamWriter outputBills = new StreamWriter(Mbill);
                try
                {
                    for (int i = 1; i <= n; i++)
                    {
                        A += b[i].BilltoString();

                        A += a[i].InfortoString();

                        A += c[i].outputDetailsBilltoString();


                        Console.WriteLine(A);
                        c[i].outputDetailsBill();
                        Console.WriteLine(c);

                    }
                    outputBills.WriteLine(A);
                    outputBills.Flush();
                    outputBills.Close();
                    Console.WriteLine("File dang_sach_hoa_don.txt da dc xuat ra o desktop");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Xuat file khong thanh cong");
                    Console.ReadKey();
                }
            }
        }
    }
}

    
