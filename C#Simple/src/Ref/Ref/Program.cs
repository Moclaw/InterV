using System;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int Bien_ref = 8;
            Console.WriteLine("Gia tri ban dau: {0}", Bien_ref); // giá trị ban đầu là: 8
            Biendoi(ref Bien_ref);
            Console.WriteLine("Gia tri sau khi Tham Chieu: {0}", Bien_ref);// sau khi sử dụng phương thức tham chiếu bằng ref giá trị thay đổi từ 8 lên 9
            Console.ReadKey();
        }
        static void Biendoi(ref int Bien_ref)
        {
            Bien_ref++; // tăng biến lên 1 đơn vị 
            Console.ReadKey();// ta có thể nói tham chiếu bằng phương thức ref khi truyền biến vào thì phải khởi tạo giá trị trước khi truyền
                              // hàm sử dụng phương thức ref sẽ thao tác trực tiếp với vùng nhớ trên RAM. Vì vậy sau khi kết thúc thì tham số bị thay đổi.
        }
    }
}
