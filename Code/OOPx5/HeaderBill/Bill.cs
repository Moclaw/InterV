using System;


namespace OOPx5.HeaderBill
{
    class Bill
    {
        private Customer.InforCustomer infor;
        private string id { get; set; } //tính đóng gói
        private int day { get; set; }
        private int mounth { get; set; }
        private int year { get; set; }
        public void InputBill()
        {
            
            // nhập hoá đơn 
            Console.Write("Ma hoa don: ");
            id = Console.ReadLine();
            //Nhập ngày
            Console.Write("Ngay lap: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Thang lap: ");
            mounth = int.Parse(Console.ReadLine());
            Console.Write("Nam lap: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            Console.Write("\tSố lượng chi tiết trong danh sách cac chi tiết hóa đơn: ");

            infor = new Customer.InforCustomer();
            infor.InputInfor();

            int amountBill;
            Console.Write("So luong hoa don can nhap: ");
            amountBill = int.Parse(Console.ReadLine());

            for (int i = 1; i <= amountBill; i++)
            {
                Console.WriteLine("Nhap thong tin don {0}", i);
                //nhập detailBill
            }
        }
        public string OutputBill()
        {

            string dataHoaDon = "";
            dataHoaDon += $"Hoa Don: " +
            $"{id}\t" +
            $"{day,2}/" +
            $"{mounth,2}/" +
            $"{year,4}\n"
            + $"Thong tin khach hang: " +
            $"{infor.IdCustomer}\t" +
            $"{infor.Name}\t" +
            $"{infor.Address}\t" +
            $"{infor.Phone}\n";
            foreach (var cthd in CTHD)
            {
                dataHoaDon += cthd.XuatDataThietBi();
            }
            return dataHoaDon;
        }

    }
}
