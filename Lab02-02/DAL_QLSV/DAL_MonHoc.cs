using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class DAL_MonHoc
    {
        QuanLySinhVienEntities1 dbContext = new QuanLySinhVienEntities1();
        public List<MonHoc> GetAll()
        {
            return dbContext.MonHocs.ToList();
        }

        public List<MonHoc> GetByMaChuyenNganh(int maChuyenNganh)
        {
            var listMonHoc = dbContext.MonHocs.Where(mh => mh.MaChuyenNganh == maChuyenNganh).ToList();
            return listMonHoc;
        }
    }
}
