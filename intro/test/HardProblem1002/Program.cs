using System;

namespace HardProblem1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int computerInput = random.Next(1, 4);

                int userInput = int.Parse(Console.ReadLine());
                int result = userInput - computerInput;

                if (result == -1 || result == 2)
                {
                    Console.WriteLine("졌습니다.");
                    break;
                }

                else if (result == -2 || result == 1)
                {
                    Console.WriteLine("이겼습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("비겼습니다.");
                }
            }
        }
    }
}