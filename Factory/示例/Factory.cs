using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Factory
    {
    }
      class FactoryA : IFactory
    {
        IProduct productA;
        public FactoryA()
        {
            this.productA = new ProductA();
        }
        public IProduct GetProduct()
        {
            return this.productA;
        }
        public IQuartz CreateQuartz()
        {
            return null;
        }
        public IEletronic CreateEletronic()
        {
            return null;
        }
        public IMechanical CreateMechanical()
        {
            return null;
        }
    }

      class FactoryB : IFactory
    {
        IProduct productB;
        public   FactoryB()
        {
            this.productB = new ProductB();

        }
        public IProduct GetProduct() {

            return this.productB;
        }
        public IQuartz CreateQuartz()
        {
            return null;
        }
        public IEletronic CreateEletronic()
        {
            return null;
        }
        public IMechanical CreateMechanical()
        {
            return null;
        }
    }

   

}
