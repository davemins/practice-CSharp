using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step04_Methods
    {
        public static void Run()
        {
            Greet("Mins");
            int sum = Add(10, 20);
            Console.WriteLine($"10 + 20 = {sum}");

            double average = GetAverage(85, 90, 95);
            Console.WriteLine($"평균 점수: {average}");

            SayHelloWultipleTiems("안녕", 3);
        }

        // 매개변수 O, 반환값 X
        private static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        // 매개변수 O, 반환값 O
        static int Add(int x, int y)
        {
            return x + y;
        }

        // 여러 매개변수 및 반환값
        static double GetAverage(int score1, int score2, int score3)
        {
            return (score1 + score2 + score3) / 3.0;
        }

        // 반복문과 메서드 결합
        static void SayHelloWultipleTiems(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }
    }
}
