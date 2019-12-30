using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBX
{
    public class BUS_BaoHanh
    {
        DAL_BaoHanh dal_BaoHanh = new DAL_BaoHanh();
        public BUS_BaoHanh()
        {

        }
        public List<DOT_BaoHanh> GetAll()
        {
            return dal_BaoHanh.GetAll();

        }
    }
}
