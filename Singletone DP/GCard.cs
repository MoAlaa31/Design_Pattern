using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_DP
{
    internal class GCard
    {
        public int Data { get; set; }
        private GCard(int data)
        {
            Data = data;
        }
        #region Static Method
        //static GCard()
        //{
        //    SingletoneObj = new GCard(123);
        //}
        //private static GCard SingletoneObj;
        //public static GCard Create()
        //{
        //    return SingletoneObj;
        //} 
        #endregion

        public static GCard SingletonObj { get; } = new GCard(0);

    }
}
