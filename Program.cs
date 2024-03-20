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
                        PrintScores(eventScores);
                        break;
                    case 2:
                        Console.WriteLine("Highest Scores:");
                        PrintHighestScores(eventScores);
                        break;
                    case 3:
                        PrintLowestScore(eventScores);
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 0);
        }


    }

    static List<EventScore>ReadEventScoresFromFile(string filename)
                {
                    List<EventScore> eventScores = new List<EventScore>(0);

                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            string name = parts[0];
                            string eventName = parts[1];
                            List<double> scores = parts.Skip(2).Select(double.Parse).ToList();

                            eventScores.Add(new EventScore(name, eventName, scores));w
                        }
                    }
                    return eventScores;
                }

                static void PrintScores(List<EventScore> eventScores)
                {
                    foreach (EventScore eventScore in eventScores)
                    {
                        Console.WriteLine(eventScore);
                    }
                }

                static void PrintHighestScores(List<EventScore> eventscores)
                {
                    EventScore highestScore = eventscores.OrderByDescending(e => e.GetTotalScore()).First();
                    Console.WriteLine("Higest Score:");
                    Console.WriteLine(highestScore);
                }
                static void PrintLowestScore(List<EventScore> eventScores)
                {
                    EventScore lowestScore = eventScores.OrderBy(e => e.GetTotalScore()).First();
                    Console.WriteLine("Lowest Score:");
                    Console.WriteLine(lowestScore);                }




            }


        }

    }
}
