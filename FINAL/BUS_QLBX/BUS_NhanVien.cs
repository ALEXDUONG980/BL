using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBX
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        public BUS_NhanVien()
        {

        }
        public List<DOT_NhanVien> GetAll()
        {
            return dal_NhanVien.GetAll();

        }
    }
}
