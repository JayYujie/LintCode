/*
*以手表题目为例  
•	所有的手表都有自己的名字；
•	所有的手表都有年月日时分秒（6个属性），并且可以显示时间；
•	所有的手表都可以连续打出五次自己的广告语；
这三个特性是手表的最基本特性：第一条是每个手表特有的属性，第二条是公共属性。第三条也是特有的品牌属性。
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
     class Watch
    {
        int watchId;
        public Watch(int watchId)
        {

            this.watchId = watchId;
            Console.WriteLine("Time Now:{0}", DateTime.Now);
        }
        /// <summary>
        /// 默认为石英表
        /// 1--电子表
        /// 2--机械表
        /// </summary>
        /// <returns></returns>
        public IProduct GetWatch()
        {
            switch (watchId)
            {
                default:
                    return new Quartz();
                case 1:
                    return new Eletronic();
                case 2:
                    return new Mechanical();
            }
        }
    }
}
