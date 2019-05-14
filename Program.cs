using System;

namespace temp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("56982326");
            
            string input = Console.ReadLine();
            int number = 0;
            bool isOk = int.TryParse(input, out number);
            if(isOk)
            {
                Console.WriteLine("Was OK");
            }
            else
            {
                Console.WriteLine("Was not ok input was: {0}", input);
            }    
                while(number > 0)
                {
                    Console.WriteLine("jojo");
                }
                Console.ReadKey();
                }
        

                }
        }
    

    class Minutes
    {
        public int Value;

        public static implicit operator int(Minutes min)
        {
            return min.Value;
        }
    }

