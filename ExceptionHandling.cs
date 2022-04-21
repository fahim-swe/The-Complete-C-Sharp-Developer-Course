using System;

namespace ExceptionHandling
{
    class Program{
        static void Main(string[] args)
        {
            int x = 3;
            int y = 0;

            double div = 0;

            try{
                div = y/x;
            }
            catch(Exception e){
                Console.WriteLine("Error is " + e.Message);
            }
            finally{
                Console.WriteLine("Result is " + div);
            }
        }
    }
}