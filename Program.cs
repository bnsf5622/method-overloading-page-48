using System;

namespace method_overloading_page_48
{
    class CallingMethod
    {
        public string HelloMethod()
        {
            return "Hello. I am from calling method";
        }
    }
    class CallingMethodUsage
    {
        public static void Main()
        {
            string text = string.Empty;
            //Object creation to activate method
            CallingMethod obj = new CallingMethod();
            //calling method
            text = obj.HelloMethod();
            Console.WriteLine(text);
            //calling static method
            Console.WriteLine(HelloStaticMethod());
            Console.ReadLine();
        }
        public static string HelloStaticMethod()
        {
            return "Hello. I am from calling static method";
        }
    }
}