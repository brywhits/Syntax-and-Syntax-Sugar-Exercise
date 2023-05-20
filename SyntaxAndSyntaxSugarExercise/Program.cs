namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Conditions
            var answer = 4;
            var response = (answer < 9)? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);




        }
    }
}
