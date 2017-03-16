using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class AbstractFactoryCASIO : IFactory
    {

        IProduct Eletronic;
        //IEletronic Eletronic;
        public AbstractFactoryCASIO()
        {
            this.Eletronic = new Eletronic();
        }
        public IProduct GetProduct()
        {
            Eletronic.ShowName();
            Eletronic.ShowAdvertisement();
            return this.Eletronic;
        }
       
        public IEletronic CreateEletronic()
        {
            return new AbstractElectronicCASIO();
        }
        public IMechanical CreateMechanical() { return null; }
        public IQuartz CreateQuartz() { return null; }
    }
}
