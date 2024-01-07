using System;

namespace Dependency_Inversion__DIP_
{
    // tạo 2 lớp giao diện 
    // 2 class con đều kế thừa 2 interface để triển khai 
    // 1 subclass để tiêm 2 đối tg userRepository ,kieudulieu
    public interface IUserRepository
    {
        void User();
        void Password();
    }

    public interface Ikieudulieu
    {
        void kieudulieu();
    }

    public class SqlUserRepository : IUserRepository, Ikieudulieu
    {
        public void User()
        {
            Console.WriteLine("Nhập tên tài khoản:");
            string tk = Console.ReadLine();
            Console.WriteLine("Tài khoản là " + tk);
        }

        public void Password()
        {
            Console.WriteLine("Nhập mật khẩu:");
            string mk = Console.ReadLine();
            Console.WriteLine("Mật khẩu là " + mk);
        }

        public void kieudulieu()
        {
            Console.WriteLine("SQL có kiểu dữ liệu SQL");
        }
    }

    public class MongoUserRepository : IUserRepository, Ikieudulieu
    {
        public void User()
        {
            Console.WriteLine("Nhập tên tài khoản:");
            string tk = Console.ReadLine();
           
        }

        public void Password()
        {
            Console.WriteLine("Nhập mật khẩu:");
            string mk = Console.ReadLine();
            
        }

        public void kieudulieu()
        {
            Console.WriteLine("Mongo có kiểu dữ liệu BSON");
        }
    }

    public class UserService
    {
        private IUserRepository userRepository;
        private Ikieudulieu kieudulieu;

        public UserService(IUserRepository userRepository, Ikieudulieu kieudulieu)
        {
            this.userRepository = userRepository;
            this.kieudulieu = kieudulieu;
        }
        public void xuat()
        {
            userRepository.User();
            userRepository.Password();
            kieudulieu.kieudulieu();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepo = new SqlUserRepository();
            Ikieudulieu kieudlieu = new SqlUserRepository();
            UserService userService = new UserService(userRepo, kieudlieu);
            
            userService.xuat();
            Console.ReadLine();
        }
    }
}
