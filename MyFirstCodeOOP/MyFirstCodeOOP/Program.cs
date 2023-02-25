using System;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
      
            try 
            {
                Console.WriteLine("Ingrese el dia");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el mes");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese  el dia");
                int y = Convert.ToInt32(Console.ReadLine());

                var dateObject = new Date(d,m,y);
                Console.WriteLine(dateObject);
            }
            catch (Exception ex) //Message error 
            {

                Console.WriteLine (ex.Message);
            }
       

        }
    }
}
