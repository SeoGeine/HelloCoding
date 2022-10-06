using System;

namespace HardProblem1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            
            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                int guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
            
        }
    }
}