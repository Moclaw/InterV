using System;

namespace Out
{
    class Program
{
        static void Main(string[] args)

        {
            int bien_out = 8;
            Console.WriteLine("Bien ban dau {0}", bien_out); //biến ban đầu khi chưa sử dụng tham chiếu out là 8
            Bien_out(out bien_out);
            Console.WriteLine("Bien sau khi tham chieu {0}", bien_out); //sau khi sử dụng tham chiếu out kết quả là 1
            Console.ReadKey();
        }
        static void Bien_out(out int bien_out)
        {
            bien_out = 0; // khi biến sử dụng tham chiếu bằng phương tức out thì ta không cần phải khởi tạo lại biến ban đầu
            bien_out++;// ta có thể nói tham chiếu bằng phương thức out là là thùng chứa kết quả khi kết thúc hàm
        }
    }
}
