namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyzer Problem");

            string message = null;

            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);

            Console.WriteLine("I am in a {0} mood. ", moodAnalyser.AnalyzeMood());
            Console.ReadKey();
        }
    }
}