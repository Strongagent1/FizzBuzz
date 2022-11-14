namespace ConsoleApp10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter the number you would like to check.  I will let you know if divisible by 3, 5, or both!");
            int userInput = int.Parse(Console.ReadLine());

            
            if (userInput % 3 == 0 && userInput % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");

            }
            else if(userInput % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if(userInput % 5 == 0)
            {
                Console.WriteLine("buzz");

            }
            else
            {
                Console.WriteLine("sorry this number is not divisible by 3 or 5!");
            }

        }        
    }
}