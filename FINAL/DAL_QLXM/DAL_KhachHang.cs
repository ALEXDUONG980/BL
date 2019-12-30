using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLXM
{
    public class DAL_KhachHang
    {
        QLXMEntities dbKhachHang = new QLXMEntities();
        public List<DOT_KhachHang> GetAll()
        {
            var listKhachHang = (from qlxm in dbKhachHang.KhachHangs
                                  select new DOT_KhachHang
                                  {
                                      MaKH = qlxm.MaKH,
                                      TenKH = qlxm.TenKH,
                                      GioiTinh = qlxm.GioiTinh == true ? "Nam" : "Nữ",
                                      DiaChi = qlxm.DiaChi,
                                      SDT = qlxm.SDT, 
                                      GhiChu = qlxm.GhiChu,
                                  }).ToList();
            return listKhachHang;

        }
    }
}
