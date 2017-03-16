using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class FactoryQuartz : IFactory
    {
        IProduct Quartz;
        public FactoryQuartz()
        {
            this.Quartz = new Quartz();
        }
        public IProduct GetProduct()
        {
            Quartz.ShowName();
            Quartz.ShowAdvertisement();
            return this.Quartz;
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
