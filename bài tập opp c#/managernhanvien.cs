using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_opp_c_
{
    internal class managernhanvien
    {
        public List<nhanvien> dsnv;
        public managernhanvien()
        {
            dsnv = new List<nhanvien>();
        }
        public void themvemoi(nhanvien nhanvien)
        {
            dsnv.Add(nhanvien);
        }
        public void sapxepnhanviengiamdan()
        {
            var dssx = dsnv.OrderByDescending(o => o.Getluong()).ToList();
            foreach (var dss in dssx)
            {
                dss.xuat();
            }
        }
        public void nhanviencotuoilonnhat()
        {
            var nvmax = dsnv.OrderByDescending(o => o.Getngaysinh()).FirstOrDefault();
           if(nvmax != null)
            {
                nvmax.xuat();
            }
        }
        public void xuattatca()
        {
           foreach(var _dsnv in dsnv)
            {
                _dsnv.xuat();
            }
        } 
    }
}
