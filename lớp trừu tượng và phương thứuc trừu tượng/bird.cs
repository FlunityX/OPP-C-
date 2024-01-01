using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lớp_trừu_tượng_và_phương_thứuc_trừu_tượng
{
    public class bird : ClassParent
    {
        public override void speak()
        {
            Console.WriteLine("liu lo liu lo");
        }
        public override void leg()
        {
            Console.WriteLine("chim có 2 chân ");
        }
    }
}
