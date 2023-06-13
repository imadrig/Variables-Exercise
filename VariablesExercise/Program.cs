namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare and Initialize variables
            string favoriteColor = "Blue";
            int age = 30;
            char bloodType = 'O';
            bool hasDriverLicense = true;
            double salary = 50500.00;
            decimal bankBalance = 10000.75m;

            Console.WriteLine($"Hello, World! The person's favorite color is {favoriteColor} and they are {age} years old. Their blood type is {bloodType} and it's {hasDriverLicense} they have a driver's license. They make ${salary} a year and have a bank balance of ${bankBalance}.");
        }
    }
}
