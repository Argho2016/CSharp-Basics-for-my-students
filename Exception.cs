using System;

namespace Exep_C
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int num1 = Convert.ToInt32(Console.ReadLine());

                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException g)
            {
                Console.WriteLine(g.Message);
            }
            catch(Exception a)
            {
                Console.WriteLine(a.Message);
            }
            finally
            {
                Console.WriteLine("Good Work");
            }

           
        }
    }
}
