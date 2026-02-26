namespace Practice_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1, twin!

            Part2();


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
            int num, guess, tries;



            num = generator.Next(501);
            bool done = false;

            tries = 5;

            Console.WriteLine("Guess your random number from 0 to 500!");
            int.TryParse(Console.ReadLine(), out guess);
            
            while (!done)
            {
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
            }
            if (guess == num)
            {
                Console.WriteLine("Nice one!");
            }





        }
        public static void Part3()
        {

            bool done = false; // We can set this to ‘true’ to end the loop
            int entry = 12345, tries = 0, pin = 0;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            while (!done)
            {
                Console.WriteLine("ENTER YOUR PIN: ");
                while (!Int32.TryParse(Console.ReadLine(), out pin))
                    Console.WriteLine("Please enter a valid number");

                tries++;
                if (pin == entry)
                {
                    Console.WriteLine("Pin Accepted.");
                    done = true; // This ends the loop
                }
                else if (tries == 3)
                {
                    Console.WriteLine("Too many incorrect tries. Access denied");
                    done = true; // This ends the loop
                }

                Console.WriteLine("You have attempted " + tries + " time(s).");
            }







        }
        public static void Part4() 
        {
            
        }
            
        
        












    }
}
