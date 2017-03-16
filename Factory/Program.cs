using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*简单工厂示例*/
            Console.WriteLine("简单工厂示例");
            Watch watch = new Watch(1);
            watch.GetWatch();

            /*工厂模式示例*/
            Console.WriteLine("工厂模式示例");
            FactoryQuartz quarta = new FactoryQuartz();
            quarta.GetProduct();

            /*抽象工厂模式示例*/
            Console.WriteLine("抽象工厂模式示例");
            AbstractFactoryCASIO abstractCASIO = new AbstractFactoryCASIO();
            abstractCASIO.GetProduct();
            abstractCASIO.CreateEletronic();

            Console.ReadKey();
        }
    }
}
