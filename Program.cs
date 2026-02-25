namespace Practice_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1, twin!

            Part1();


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
    }   

        
}
