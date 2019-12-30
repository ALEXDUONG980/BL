using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBX
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        public BUS_KhachHang()
        {

        }
        public List<DOT_KhachHang> GetAll()
        {
            return dal_KhachHang.GetAll();

        }
    }
}
