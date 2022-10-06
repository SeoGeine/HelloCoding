using System;

namespace DoorLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[passcodeLength];

            for (int passcodeTryCount = 0; passcodeTryCount < 5; passcodeTryCount++)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}