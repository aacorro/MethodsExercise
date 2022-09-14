namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex. 1

            //Name: 
            //Favorite Color: 
            //Favorite Animal: 
            //Favorite Band: 

            Console.WriteLine("Hello! What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}! Please answer the following questions in order to complete your profile: What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Awesome, {color} is a nice color! Now, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}! Great! One last question: What is your favorite band?");
            var band = Console.ReadLine();


            Console.WriteLine("Thanks! Here is your profile:");

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");
            Console.WriteLine("");
        }
    }
}