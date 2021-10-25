using System;

namespace moclaw5
{
    class Program
    {
       static void Main(string[] args)
        {
            int bien = 8;
            Console.WriteLine("Biến ban đầu: {0}", bien); // biến ban đầu xuất ra = 8
            bien_doi_tham_tri(bien);
            Console.WriteLine("Sau biến đổi: {0}", bien); // sau khi biến đổi xuất ra = 8
            Console.ReadKey();
        }
        static void bien_doi_tham_tri(int bien)
        {
            bien++; // biến cộng lên 1 đơn vị
        }
    }// kết quả xuất ra như ban đầu ==> tham số không biến đổi từ đó kết luật tham trị là xử lý tính toán và không làm thay đổi giá trị
}
        