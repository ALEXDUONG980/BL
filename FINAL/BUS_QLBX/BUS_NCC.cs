using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBX
{
    public class BUS_NCC
    {
        DAL_NCC dal_NCC = new DAL_NCC();
        public BUS_NCC()
        {

        }
        public List<DOT_NCC> GetAll()
        {
            return dal_NCC.GetAll();

        }
    }
}
