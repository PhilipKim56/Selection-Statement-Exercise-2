namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavoriteSubject();
        }
        public static void FavoriteSubject()
        {
            Console.WriteLine("What is your favorite subject?");
            var userInput = (Console.ReadLine());

            
            switch (userInput) 
            {
                case "Math":
                    Console.WriteLine($"{userInput}? Want to join the math club?");
                    break;
                case "English":
                    Console.WriteLine($"{userInput}? What is your favorite book?");
                    break;
                case "Science":
                    Console.WriteLine($"{userInput}? Have you ever done the mentos rocket?");
                    break;
                case "Gym":
                    Console.WriteLine($"{userInput} nothing like a good sweat.");
                    break;
                case "Art":
                    Console.WriteLine($"{userInput} really draws you in.");
                    break;
                default : Console.WriteLine($"{userInput}? How interesting...");
                    break;
            }
        }
    }
    
}