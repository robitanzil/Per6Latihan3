using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan3
{
    class Kakak : Anak
    {

        public int NoSepatu { get; set; }

        public Kakak(int NoSepatu)
        {
            this.NoSepatu = NoSepatu;
        }

        public override sealed int UangJajan
        {
            get
            {
                return base.UangJajan;
            }
            set
            {
                base.UangJajan = value + 2000;
            }
        }
    
    }
}
