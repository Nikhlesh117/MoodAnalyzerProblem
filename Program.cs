namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyzer Problem\n");

            string message = " ";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            System.Console.WriteLine("I am in a {0} mood. ", moodAnalyser.AnalyzeMood());
            Console.ReadKey();
        }
    }
}