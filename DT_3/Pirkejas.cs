using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_3
{
    class Pirkejas
    {
        public string amzius { get; set; } //jaunas, vidutinis, senas
        public string issilavinimas { get; set; } //pagrindinis, vidurinis, aukstasis
        public string atlyginimas { get; set; } //mazas, vidutinis, didelis
        public bool arPirko { get; set; }

        public Pirkejas (string amzius, string issilavinimas, string atlyginimas, bool arPirko)
        {
            this.amzius = amzius;
            this.issilavinimas = issilavinimas;
            this.atlyginimas = atlyginimas;
            this.arPirko = arPirko;
        }
    }
}
