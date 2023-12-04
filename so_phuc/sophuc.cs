using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class sophuc
    {
        public double phanthuc;
        public double phanao;
        public sophuc(double phanthuc,double phanao) 
        {
            this.phanthuc = phanthuc;
            this.phanao = phanao;
        }
        public void xuat()
        {
            Console.WriteLine(" so phuc cua ban la : {0} + {1}i",phanthuc,phanao);
        } 
    }
}
