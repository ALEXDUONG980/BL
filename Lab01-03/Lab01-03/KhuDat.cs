using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class KhuDat:Dat
    {
        public KhuDat()
        {           
        }
        public KhuDat(string diaDiem, double giaBan, double dienTich):base(diaDiem, giaBan, dienTich)
        {
        }

        public virtual void Input()
        {
            base.Input();   
        }

        public virtual void Output()
        {
            base.Output();
        }
    }
}
