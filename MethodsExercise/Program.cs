namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            //Name: 
            //Favorite Color: 
            //Favorite Animal: 
            //Favorite Band: 

            Console.WriteLine("Hello! What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}! Please answer the following questions in order to complete your profile:");
                Console.WriteLine($"What is your favorite color?");
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


            // Bonus * fun story *

            Console.WriteLine($"Here is a customized story for you {name}:");

            Console.WriteLine($"There was only half a {animal} in the apple. At first, {name} didn't quite " +
                $"comprehend what this meant. \"Why would only half a {animal} be living in an apple?\" " +
                $"{name} turned {color} from embarrassment and quickly spit out the last bite expecting " +
                $"to see the other half of the {animal}. Suddenly, the band: {band} staring playing \"Meat is Murder...\".");


            // Exercise 2

            // Sum

            Console.WriteLine($"Now, is boasting time {name}! let\'s find out about your programmign skills:");

            Console.WriteLine("How many front-end languages do you konw?");
             int frontEnd = int.Parse(Console.ReadLine()!);

             Console.WriteLine("How many back-end languages do you know?");
            int backEnd = int.Parse(Console.ReadLine()!);

            
            int languagesTotal = Sum(frontEnd, backEnd);
            Console.WriteLine($"You have the power of knowing {languagesTotal} programming languages!");

                              // Multiply

            Console.WriteLine($"Finally, let\'s calculate the volume of your favority room in your house (in feet): ");

            Console.WriteLine("What is the length?");
            int length = int.Parse(Console.ReadLine()!);

            Console.WriteLine("What is the width?");
            int width = int.Parse(Console.ReadLine()!);


            Console.WriteLine("Last, what is the height?");
            int height = int.Parse(Console.ReadLine()!);


            int volumeTotal = Multiply(length, width, height);
            Console.WriteLine($"The volume of your favorite room is: {volumeTotal} feets.");


        }


              // Exercise 2

        //public static int Sum(int frontEnd, int backEnd)
        //{
        //    return frontEnd + backEnd;
        //}
        //public static int Multiply(int length, int width, int height)
        //{
        //    return length * width / height;
        //} 


            // Challenge (no the best way to use params. For learning purpose only)

        public static int Sum(params int[] languages)
        {
            int sum = 0;
            for (int i = 0; i < languages.Length; i++)
            {
                sum = sum + languages[i];
                
            }
            return sum;
        }
        public static int Multiply(params int[] volume)
        {
            int sum = 0;
            for (int i = 0; i < volume.Length; i++)
            {
                sum = sum + volume[i];
                
            }
            return sum;

        }

    } 
}