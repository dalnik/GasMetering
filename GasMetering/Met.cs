using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasMetering
{
    class Met
    {
        public string Month { get; set; }
        public int GasPoint { get; set; }
        public int GasMet { get; set; }

        public override string ToString()
        {
            return $"{Month} gaspoint: {GasPoint} gasmet: {GasMet}";
        }
    }
}
