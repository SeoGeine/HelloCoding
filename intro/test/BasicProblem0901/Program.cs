using System;

namespace BasicProblem0901
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumbers = new int[friendCount];

            for (int index = 0; index < friendCount; index = index + 1)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumbers[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < friendCount; index = index + 1)
            {
                Console.Write(index);
                Console.Write("번째 친구가 가져간 사과의 개수는 ");
                Console.Write(appleNumbers[index]);
                Console.WriteLine("개입니다.");
            }
        }
    }
}