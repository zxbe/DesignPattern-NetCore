using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Singleton
{
    /// <summary>
    /// 利用 Lazy（内部已经实现多线程同步，因此性能也有所损耗） 实现懒加载 
    /// </summary>
    public sealed class Singleton_Lazy
    {
        private static readonly Lazy<Singleton_Lazy> lazy = new Lazy<Singleton_Lazy>(() => new Singleton_Lazy());
        public static string static_property = GetStr("初始化 Singleton_Lazy 静态成员字段"); //加入了静态字段或属性, 一旦在某个地方引用了静态属性，则CreateInstance也会执行。

        public static Singleton_Lazy Instance => lazy.Value;
        //public static Singleton_Lazy Instance
        //{
        //    get
        //    {
        //        return lazy.Value;
        //    }
        //}

        private Singleton_Lazy()
        {
            Console.WriteLine($"创建了实例: {this}@{this.GetHashCode()}");
        }

        public static String GetStr(String str)
        {
            Console.WriteLine(str);
            return str;
        }
    }
}
