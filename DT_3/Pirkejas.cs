using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_3
{
    class Pirkejas
    {
        public int vIndex { get; set; }
        public int kIndex { get; set; }
        public int zIndex { get; set; }
        public bool maitinimas { get; set; }
        public int aIndex { get; set; }

        public Pirkejas (int vIndex, int kIndex, int zIndex, bool maitinimas, int aIndex)
        {
            this.vIndex = vIndex;
            this.kIndex = kIndex;
            this.zIndex = zIndex;
            this.maitinimas = maitinimas;
            this.aIndex = aIndex;
        }
    }
}
