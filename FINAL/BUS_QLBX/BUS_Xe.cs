using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBX
{
    public class BUS_Xe
    {
        DAL_Xe dal_Xe = new DAL_Xe();
        public BUS_Xe()
        {

        }
        public List<DOT_Xe> GetAll()
        {
            return dal_Xe.GetAll();

        }
    }
}
