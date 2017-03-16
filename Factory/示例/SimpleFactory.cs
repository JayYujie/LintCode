/*
*以手表题目为例  
•	所有的手表都有自己的名字；
•	所有的手表都有年月日时分秒（6个属性），并且可以显示时间；
•	所有的手表都可以连续打出五次自己的广告语；
这里只考虑  手表工厂和手表种类（石英  机械 电子）的基本实现
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum Food
    {
        A = 0,
        B = 1,
        C = 2
    }
    class SimpleFactory
    {
        int productNum;
        public SimpleFactory(int productNum)
        {
            this.productNum = productNum;
        }
        public IFood GetProduct()
        {
            switch (productNum)
            {
                default:
                    return new A();
                case 1:
                    return new B();
                case 2:
                    return new C();
            }
        }
    }
    interface IFood { }
    class A : IFood { }
    class B : IFood { }
    class C : IFood { }
}
