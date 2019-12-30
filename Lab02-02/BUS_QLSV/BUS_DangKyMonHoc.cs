using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSV;

namespace BUS_QLSV
{
    public class BUS_DangKyMonHoc
    {

        DAL_DangKyMonHoc dal_DangKyMonHoc = new DAL_DangKyMonHoc();
        public BUS_DangKyMonHoc()
        {

        }
        public List<DangKyMonHoc> GetAll()
        {
            return dal_DangKyMonHoc.GetAll();

        }
    }
}
