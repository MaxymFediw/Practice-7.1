namespace Practice_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1, twin!

            Part3();


        }

        public static void Part1() 
        {

            int pin = 12345;
            int entry;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.Write("ENTER YOUR PIN: ");
            
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();
            while (entry != pin)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.Write("ENTER YOUR PIN: ");
                int.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");



        }

        public static void Part2() 
        {
            Random generator = new Random();
            int num, guess;
            
            
            num = generator.Next(501);


            Console.WriteLine("Guess your random number from 0 to 500!");
            int.TryParse(Console.ReadLine(), out guess);

            while (guess != num)
           {
                Console.WriteLine("Try again!");
                int.TryParse(Console.ReadLine(), out guess);

                if (guess < num)
                {
                    Console.WriteLine("Go up!");
                    Console.WriteLine("Guess your new number!");
                }

                if (guess > num)
                {
                    Console.WriteLine("Go down!");
                    Console.WriteLine("Guess your new number!");
                }

                
            }  
        
                if (guess == num)
                {
                    Console.WriteLine("Nice one!");
                }
        
        
        
        
        
        }
        public static void Part3() 
        {
        
        
        
        
        
        
        
        
        
        }
    }   
        
     
    
        
        
        
        
        
        
    

        
}
