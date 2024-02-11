using System;

namespace DI_Property
{
    public interface IUserRepository
    {
        void Add(User user);
    }

    public class UserService
    {
        public IUserRepository UserRepository { get; set; }

        public void AddUser(User user)
        {
            UserRepository.Add(user);
        }
    }

    public class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            Console.WriteLine("Adding user to the database: " + user.Name);
            // Logic để thêm user vào cơ sở dữ liệu
        }
    }

    public class User
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo instance của UserRepository
            IUserRepository userRepository = new UserRepository();

            // Tạo instance của UserService và cung cấp UserRepository thông qua Property Injection
            UserService userService = new UserService
            {
                UserRepository = userRepository
            };

            // Sử dụng UserService để thêm người dùng mới
            User newUser = new User { Name = "John" };
            userService.AddUser(newUser);
        }
    }
}