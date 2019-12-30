using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLXM
{
    public class DAL_Xe
    {
        QLXMEntities dbXe = new QLXMEntities();
        public List<DOT_Xe> GetAll()
        {
            var listXe = (from qlxm in dbXe.Xes
                                  select new DOT_Xe
                                  {
                                      MaXe = qlxm.MaXe,
                                      TenXe = qlxm.TenXe,
                                      MauXe = qlxm.MauXe,
                                      MaBH = qlxm.MaBH,
                                      MaNCC = qlxm.MaNCC, 
                                      GiaBan = qlxm.GiaBan,
                                      NgayLap = qlxm.NgayNhap
                                  }).ToList();
            return listXe;

        }
    }
}
