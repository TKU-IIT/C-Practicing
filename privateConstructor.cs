using System;

namespace privateConstructor
{
    class privateConstructor
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            objCaller objc = new objCaller();
            
        }
    }
    class obj
    {
        int a, b;
        public int result;
        private void Run1()
        {
            Console.WriteLine("private");
            result = a + b;
        }
        public int Main1(int a, int b)
        {
            this.a = a + 25;
            this.b = b + 25;
            Run1();
            return result;
        }

    }
    class objCaller
    {
        public objCaller()
        {
            obj a = new obj();
            a.Main1(35, 45);
            Console.WriteLine("Result is: "+a.result);
        }
    }
}
