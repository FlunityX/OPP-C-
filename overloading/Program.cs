namespace overloading
{
    internal class Program
    {
        /*Overloading là một tính năng trong lập trình C# cho phép bạn định nghĩa nhiều phương thức có cùng tên trong một lớp,
        nhưng với các danh sách tham số khác nhau. Các quy tắc overloading cho phép bạn có các phương thức cùng tên nhưng 
        với số lượng hoặc kiểu tham số khác nhau.*/
        static void Main(string[] args)
        {
           khaitrienoverloading khaitriensonguyen = new khaitrienoverloading();
            Console.WriteLine(khaitriensonguyen.congso(2, 3));
            Console.WriteLine(khaitriensonguyen.congso(2.5, 3.5));
            Console.WriteLine(khaitriensonguyen.congso("hello" , "world"));
            Console.ReadLine();
        }
        
    }
}