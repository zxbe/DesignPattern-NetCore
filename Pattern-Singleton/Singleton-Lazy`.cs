using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Singleton
{
    public class Singleton_Lazy<T> where T : new()
    {
        //public static Func<T> Instance1 = System.Linq.Expressions.Expression.Lambda<Func<T>>(System.Linq.Expressions.Expression.New(typeof(T))).Compile();
        private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());
        public static string static_property = GetStr("初始化 Singleton_Lazy<T> 静态成员字段"); //加入了静态字段或属性, 一旦在某个地方引用了静态属性，则CreateInstance也会执行。

        public static T Instance => lazy.Value;
        //public static Singleton_Lazy Instance
        //{
        //    get
        //    {
        //        return lazy.Value;
        //    }
        //}

        protected Singleton_Lazy()
        {
            Console.WriteLine($"创建了实例: {this}@{this.GetHashCode()}");
        }

        public static String GetStr(String str)
        {
            Console.WriteLine(str);
            return str;
        }
    }

    public class Singleton_Lazy1 : Singleton_Lazy<Singleton_Lazy1>
    {
        //public Singleton_Lazy1()
        //{
        //    Console.WriteLine($"创建了实例: {this}@{this.GetHashCode()}");
        //}
    }
}
