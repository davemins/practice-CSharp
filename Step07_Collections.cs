using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step07_Collections
    {
        public static void Run()
        {
            // 1. 배열 (고정 크기)
            string[] fruits = new string[3];
            fruits[0] = "A";
            fruits[1] = "B";
            fruits[2] = "C";

            Console.WriteLine("====배열====");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            // 2. 리스트 (크기 유동적)
            List<int> scores = new List<int>();
            scores.Add(85);
            scores.Add(92);
            scores.Add(78);

            Console.WriteLine("\n====리스트====");
            foreach (int score in scores)
            {
                Console.WriteLine($"{score}");
            }

            // 3. 초기화와 유용한 메서드들
            List<string> names = new List<string> { "Jisoo", "Mins", "Joon" };
            names.Remove("Mins");
            names.Add("Nari");

            Console.WriteLine("\n====수정된 이름 목록====");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"\n총 인원 수 : {names.Count}");
        }
    }
}
