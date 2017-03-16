using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        /**********************************饿汉模式*********************************/
        //private static Logger instance = new Logger();
        //private Logger() { }
        //public static Logger GetInstance()
        //{
        //    return instance;
        //}
        /**********************************懒汉模式*********************************/
        private static Logger instance;
        private Logger() { }
        private static object initLockHelper = new object();
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (initLockHelper)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
 
            }
            return instance;
        }
    }
}
