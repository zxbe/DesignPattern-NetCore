using System;

namespace Pattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

          
            Console.WriteLine("==> 测试 Singleton_static");
            Singleton_static.GetStr("手动调用 Singleton_static.GetSring() 方法");

            //var y = Singleton_static.static_property;//调用静态字段/属性,CreateInstance也会初始化
            Console.WriteLine("我是分隔符");
            Console.WriteLine("我是分隔符");

            sw.Start();
            var foo = Singleton_static.CreateInstance; // 无打印
            sw.Stop();
            Console.WriteLine($"耗时：{sw.ElapsedTicks}ms");
            foo = Singleton_static.CreateInstance; // 无打印

            Console.WriteLine("==> 测试 Singleton_Lazy");
            Singleton_Lazy.GetStr("手动调用 Singleton_Lazy.GetSring() 方法");
            //var lazy = Singleton_Lazy.static_property;//调用静态字段/属性,CreateInstance也会初始化
            Console.WriteLine("我是分隔符");
            Console.WriteLine("我是分隔符");
            sw.Restart();
            var lazy1 = Singleton_Lazy.Instance; // 无打印
            sw.Stop();
            Console.WriteLine($"耗时：{sw.ElapsedTicks}ms");

            var lazy2 = Singleton_Lazy.Instance; // 无打印


            Console.WriteLine("==> 测试 Singleton_Lazy<T>");
            Singleton_static.GetStr("手动调用 Singleton_Lazy<T>.GetSring() 方法");
            var lazyT = Singleton_Lazy1.static_property;//调用静态字段/属性,CreateInstance也会初始化
            Console.WriteLine("我是分隔符");
            Console.WriteLine("我是分隔符");
            sw.Restart();
            var lazyT1 = Singleton_Lazy1.Instance; // 无打印
            sw.Stop();
            Console.WriteLine($"耗时：{sw.ElapsedTicks}ms");

            //var lazyT2 = Singleton_Lazy1.Instance; // 无打印
            var lazyT3 = Singleton_Lazy1.Instance; // 无打印
            //var lazyT4 = Singleton_Lazy1.Instance; // 无打印
        }

    }
}
