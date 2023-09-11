using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace Labb1._2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random string!");
            string input = Console.ReadLine();
            List<string> strings = new List<string>();
            
            for (int startValue = 0; startValue < input.Length - 1; startValue++)
            {
                for (int endValue = startValue + 1; endValue < input.Length; endValue++)
                {
                    if (char.IsLetter(input[endValue]))
                    {
                        break;
                    }

                    if (input[startValue] == input[endValue])
                    {

                        strings.Add(input[startValue..(endValue + 1)]);

                        break;
                    }
                }
            }
            strings.ForEach(s =>
            {
                Console.Write(input[0..input.IndexOf(s, 0)]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(s); 
                Console.ResetColor();
                Console.WriteLine(input[(input.IndexOf(s, 0) + s.Length)..^0]);
                Console.ResetColor();
            });
                long sum = strings.Select(s => long.Parse(s)).Sum();
                Console.WriteLine($"The total sum is; {sum}!");

        }
    }
}

