using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLXM
{
    public class DAL_HopDong
    {
        QLXMEntities dbHopDong = new QLXMEntities();
        public List<DOT_HopDong> GetAll()
        {
            var listHopDong = (from qlxm in dbHopDong.HopDongs
                                  select new DOT_HopDong
                                  {
                                      MaHD = qlxm.MaHD,
                                      MaKH = qlxm.MaKH,
                                      MaNV = qlxm.MaNV,
                                      MaXe = qlxm.MaXe,
                                      NgayLap = qlxm.NgayLap
                                  }).ToList();
            return listHopDong;

        }
    }
}
