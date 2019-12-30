using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBX
{
    public class BUS_HopDong
    {
        DAL_HopDong dal_HopDong = new DAL_HopDong();
        public BUS_HopDong()
        {

        }
        public List<DOT_HopDong> GetAll()
        {
            return dal_HopDong.GetAll();

        }
    }
}
