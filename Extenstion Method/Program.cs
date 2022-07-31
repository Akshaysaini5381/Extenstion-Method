using System;

namespace Extenstion_Method
{
    static class a 
    {
     public static void M(this Program d)
        {
            Console.WriteLine("saini :");
        }

        public static void M1(this Program d)
        {
            Console.WriteLine("ashi : :");
        }

    }

    
    class Program
    {

      /*  void m()
        {
            Console.WriteLine("akshay :");
        }*/
        static void Main(string[] args)
        {
            Program obj = new Program();
            //  obj.m();
            obj.M();
            obj.M1();
        }
    }
}
