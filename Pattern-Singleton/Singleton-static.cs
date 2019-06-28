using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Singleton
{
    public sealed class Singleton_static
    {
        /// <summary>
        /// 一旦在某个地方引用了静态属性，则CreateInstance也会执行。
        /// </summary>
        public static string static_property = GetStr("初始化 Singleton_static 静态成员字段"); //加入了静态字段或属性, 一旦在某个地方引用了静态属性，则CreateInstance也会执行。
        //public static String X { get; set; } = GetStr("初始化 Singleton_static 静态成员字段");

        public static Singleton_static CreateInstance { get; } = new Singleton_static();
        private Singleton_static()
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
