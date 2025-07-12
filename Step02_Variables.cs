using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step02_Variables
    {
        public static void Run()
        {
            // 변수 선언
            int age = 25;
            double height = 174;
            bool isAdult = age >= 18;
            char grade = 'A';
            string name = "davemins";

            // 출력
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");

            // var 키워드
            var score = 95;
            Console.WriteLine($"Score: {score}");
        }
    }
}
