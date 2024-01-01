using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Quanlyve
    {
        List<vebinhthuong> dsve;
        public Quanlyve()
        {
            dsve = new List<vebinhthuong>();
        }
        public Quanlyve(List<vebinhthuong> dsve)
        {
            this.dsve = dsve;
        }
        public void themvemoi(vebinhthuong vemoi)
        {
            dsve.Add(vemoi);
        }
        public void Timkiemmve(string mavemuontim)
        {
            var dstimdc = dsve.Where(o => o.getmave() == mavemuontim);

            foreach (var item in dstimdc)
            {
                item.xuat();
            }


        }
        public void xoatheomave(string mavemuonxoa)
        {
            var dstimduoc = dsve.Where(o => o.getmave() == mavemuonxoa);
            foreach (var item in dstimduoc)
            {
                dsve.Remove(item);
            }
        }

        public void hienthi()
        {
            foreach (var i in dsve)
            {
                i.xuat();
            }
    }
    } 
}

