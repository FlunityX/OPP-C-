using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lớp_trừu_tượng_và_phương_thứuc_trừu_tượng
{
    public  class Dog: ClassParent
    {
        public override void speak()
        {
            Console.WriteLine("go go go");
        }
        public override void leg()
        {
            Console.WriteLine(" chó có 4 chân ");
        }
    }
}
