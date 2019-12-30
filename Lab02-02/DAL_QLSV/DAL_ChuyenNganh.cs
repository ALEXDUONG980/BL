using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class DAL_ChuyenNganh
    {
        QuanLySinhVienEntities1 dbContext = new QuanLySinhVienEntities1();
        public List<ChuyenNganh> GetAll()
        {
            return dbContext.ChuyenNganhs.ToList();
        }
    }
}
