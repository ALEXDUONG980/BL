using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLXM
{
    public class DAL_NhanVien
    {
        QLXMEntities dbNhanVien = new QLXMEntities();
        public List<DOT_NhanVien> GetAll()
        {
            var listNhanVien = (from qlxm in dbNhanVien.NhanViens
                                  select new DOT_NhanVien
                                  {
                                      MaNV = qlxm.MaNV,
                                      HoVaTen = qlxm.HoVaTen,
                                      NgaySinh = qlxm.NgaySinh,
                                      GioiTinh = qlxm.GioiTinh == true ? "Nam" : "Nữ",
                                      DiaChi = qlxm.DiaChi,
                                      SDT = qlxm.SDT, 
                                      ChucVu = qlxm.ChucVu,
                                      NgayVaoLam = qlxm.NgayVaoLam
                                  }).ToList();
            return listNhanVien;

        }
    }
}
