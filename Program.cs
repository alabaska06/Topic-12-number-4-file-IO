using System.Xml.Serialization;

namespace Topic_12_number_4_file_IO
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<EventScore> eventScores = ReadEventScoresFromFile(@"results.txt");

            int choice;
            do
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1. Print Scores");
                Console.WriteLine("2. Highest Score");
                Console.WriteLine("3. Lowest Score");
                Console.WriteLine("0. Exit");

                Console.WriteLine("\nEnter your choice:\n");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Scores:");
                        Console.WriteLine(eventScores);
                        break;
                    case 2:
                        Console.WriteLine("Highest Scores:");
                        Console.WriteLine();
                        break;
                }
            }


        }

    }
}
