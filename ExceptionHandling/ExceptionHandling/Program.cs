using System;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 9;
            double div = 0;
            //trying to divide two numbers
            try
            {
                div = y / x;
            }
            //if try fails catches an exception
            catch (Exception e)
            {
                Console.WriteLine("Error is :" + e.Message);
            }
            //finally must execute
            finally
            {
                Console.WriteLine("Result is : " + div);
            }
        }
    }
}
