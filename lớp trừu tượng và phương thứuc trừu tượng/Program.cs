using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lớp_trừu_tượng_và_phương_thứuc_trừu_tượng
{

    internal class Program
    {
        static void Main(string[] args)
        {
            bird a = new bird();
            a.speak();
            a.leg();
            Dog b = new Dog();
            b.speak();
            b.leg();
            Console.ReadLine();
        }
    }
}
