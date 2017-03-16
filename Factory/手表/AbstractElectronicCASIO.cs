using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class AbstractElectronicCASIO:IEletronic
    {
        public AbstractElectronicCASIO() {
            SelfWinding();
        }


        public void SelfWinding() {
            Console.WriteLine("I will Self-Winding!");
        }
    }
}
