using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Eletronic : IProduct
    {
        public Eletronic()
        {
            ShowTime();
        }
        public void ShowAdvertisement()
        {

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Advertisement Eletronic Watch");
            }
        }
        public void ShowName()
        {
            Console.WriteLine("I'm Eletronic Watch");
        }
        public void ShowTime()
        {
            Console.WriteLine("Time Now:{0}", DateTime.Now);
        }
    }
}
