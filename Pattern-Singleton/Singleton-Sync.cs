using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Singleton
{
    /// <summary>
    /// 同步 单例
    /// </summary>
    public class Singleton_Sync
    {

        private static Singleton_Sync _uniqueInstance;

        private Singleton_Sync()
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public static Singleton_Sync GetInstance()
        {
            return _uniqueInstance ?? (_uniqueInstance = new Singleton_Sync());
        }
    }
}
