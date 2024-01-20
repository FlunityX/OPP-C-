using System;

namespace tiêm_phụ_thuộc
{
    /*Hãy xây dựng một ứng dụng quản lý sản phẩm sử dụng Dependency Injection trong ngôn ngữ lập trình C#.
     * Hệ thống sẽ bao gồm các thành phần sau:
     * Interface IProductService:
       Định nghĩa một interface có một phương thức: GetProductInfo.
       GetProductInfo nhận vào một mã sản phẩm và trả về thông tin chi tiết về sản phẩm đó.
       Lớp ProductService implement IProductService:

      Thực hiện phương thức của interface IProductService.
       Sử dụng một cách giả lập để trả về thông tin chi tiết về sản phẩm (ví dụ: tên sản phẩm, giá, mô tả).
       Lớp ProductManager:

      Sử dụng Dependency Injection để inject IProductService vào lớp.
      Cung cấp một phương thức để hiển thị thông tin chi tiết của một sản phẩm dựa trên mã sản phẩm được nhập từ người dùng.
      Lớp Program:

     Sử dụng Dependency Injection để inject ProductManager vào chương trình.
     Viết mã trong hàm Main để thực hiện các thao tác như hiển thị thông tin sản phẩm.*/
    public interface IProductService
    {
       void GetProductName(string s);
    }
      class ProductService : IProductService
    {
        public void GetProductName(string s)
        {
            if (s == "a" .ToLower())
            {
                Console.WriteLine("thông tin mat hang :");
                Console.WriteLine(" khách hàng :");
            }
        }
    }
    public class ProductManager
    {
        private IProductService _service;
        public ProductManager(IProductService service)
        {
            _service = service;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService service = new ProductService();
            service.GetProductName("a");
            Console.ReadLine();
        }
    }
}
