using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLXM
{
    public class DAL_BaoHanh
    {
        QLXMEntities dbBaoHanh = new QLXMEntities();
        public List<DOT_BaoHanh> GetAll()
        {
            var listBaoHanh = (from qlxm in dbBaoHanh.BaoHanhs
                                  select new DOT_BaoHanh
                                  {
                                      MaBH = qlxm.MaBH,
                                      MaNCC = qlxm.MaNCC,
                                      ThoiGian = qlxm.ThoiGian
                                  }).ToList();
            return listBaoHanh;

        }
    }
}
