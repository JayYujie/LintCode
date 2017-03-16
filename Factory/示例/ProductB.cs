using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ProductB:IProduct
    {
        public ProductB()
        {
            ShowName();
        }
        public void ShowAdvertisement()
        {

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Advertisement ProductB");
            }
        }
        public void ShowName()
        {
            Console.WriteLine("I'm ProductB");
        }
        public void ShowTime()
        {
            Console.WriteLine("Time Now:{0}", DateTime.Now);
        }
         
    }
}
