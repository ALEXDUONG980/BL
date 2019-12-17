using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSV;

namespace BUS_QLSV
{
    public class BUS_ChuyenNganh
    {
        QuanLySinhVienEntities1 dbContext = new QuanLySinhVienEntities1();

        public BUS_ChuyenNganh()
        {

        }
        public List<ChuyenNganh> GetChuyenNganh()
        {
            return dbContext.ChuyenNganhs.ToList();

        }
    }
}
