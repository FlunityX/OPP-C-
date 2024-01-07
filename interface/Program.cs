using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        //Một interface chỉ định các hành vi mà một lớp phải tuân thủ khi triển khai nó.
        //Đó là một cách để định nghĩa các hợp đồng mà các lớp phải tuân thủ để cung cấp tính đa hình và phân tách trách nhiệm
        public interface Icar
        {
            void hangxe();
            string mauxe();
        }
        public class xeToyota:Icar {
        public void hangxe()
            {
                Console.WriteLine("hang toyota");
            }
        public string mauxe()
            {
                return "red";
            }
        }
        public class xehonda:Icar
        {
            public void hangxe()
            {
                Console.WriteLine("hang honda");
            }
            public string mauxe()
            {
                return "blue ";
            }
        }
        public class xeSuzuki : Icar
        {
            public void hangxe()
            {
                Console.WriteLine("hang suzuki");
            }
            public string mauxe()
            {
                return "green ";
            }
        }
        static void Main(string[] args)
        {
            xeToyota xe1 = new xeToyota();
            xe1.hangxe();
            string color = xe1.mauxe();
            Console.WriteLine("mau xe " + color);
            xeSuzuki xe2 = new xeSuzuki();
            xe2.hangxe(); 
            string color1 = xe2.mauxe();
            Console.WriteLine("mau xe " + color1);
            xehonda xe3 = new xehonda();
            string color2 = xe3.mauxe();
            xe3.hangxe();
            Console.WriteLine("mau xe " + color2);
            Console.ReadLine();
        }
    }
}
