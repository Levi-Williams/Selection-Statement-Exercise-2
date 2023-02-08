namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite school subject?");
            string favUserSchoolSubject = Console.ReadLine();
             switch (favUserSchoolSubject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("Math can be fun until you reach high level calculus");
                    break;
                case "science":
                    Console.WriteLine("An aptitude for science shows a curiosity for the world around us!");
                    break;
                case "english":
                    Console.WriteLine("Learning proper english is surprisingly difficult.");
                    break;
                case "art":
                    Console.WriteLine("I think we can all appreciate good art. Difficult thing is, art is all subjective");
                    break;
                case "gym":
                    Console.WriteLine("A healthy body is also a healthy mind. Pay attention to physical education");
                    break;
                case "history":
                    Console.WriteLine("Understanding our past is the best way to pave a better way forward.");
                    break;
                default: Console.WriteLine("I don't recognize that input.");
                    break;
            }





        }
    }
}