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

            Console.WriteLine($"{color}, great! Now, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}, awesome! One last question: What is your favorite band?");
            var band = Console.ReadLine();

            // User Profile

            Console.WriteLine("Thanks! Here is your profile:");

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");
        

            // Bonus * fun story
            Console.WriteLine($"Here is a customized story for you {name}:");

            Console.WriteLine($"There was only half a {animal} in the apple. At first, {name} didn't quite " +
                $"comprehend what this meant. \"Why would only half a {animal} be living in an apple?\" " +
                $"{name} turned {color} from embarrassment and quickly spit out the last bite expecting " +
                $"to see the other half of the {animal}. Suddenly, the band: {band} staring playing \"Meat is Murder...\".");
        }
    }
}