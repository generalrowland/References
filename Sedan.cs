using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class Sedan : IAutomobile
    {
        public double Speed => { get; private set; };

        public int Wheels => { get; private set; };

        public string LicensePlate => { get; private set; };

        public void Stringify()
        {
            throw new NotImplementedException();
        }
    }
}
