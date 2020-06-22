using System;

namespace homework2
{    class Program
    {        
        static void dayofweek(int numberday)
        {            
         string[] dayweek = new string[7]
         {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday","Sunday"};
         Console.WriteLine(numberday + " day of the week is:  " + dayweek[numberday - 1]);
        }        
        public static void Main(string[] args)
        {
            try
            {Console.WriteLine("Enter the day number of the week from 1 to 7");
             int day = Convert.ToInt32(Console.ReadLine());
                dayofweek(day);
            }
            catch
            {Console.WriteLine("You entered an invalid value. \nEnter a number from 1 to 7!");
            }
            Console.ReadKey();
        }
    }
}
