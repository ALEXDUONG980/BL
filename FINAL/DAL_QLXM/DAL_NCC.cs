using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLXM
{
    public class DAL_NCC
    {
        QLXMEntities dbNCC = new QLXMEntities();
        public List<DOT_NCC> GetAll()
        {
            var listNCC = (from qlxm in dbNCC.NCCs
                                  select new DOT_NCC
                                  {
                                      MaNCC = qlxm.MaNCC,
                                      TenNCC = qlxm.TenNCC,
                                      DiaChi = qlxm.DiaChi,
                                      SDT = qlxm.SDT, 
                                      Email = qlxm.Email,
                                  }).ToList();
            return listNCC;

        }
    }
}
