using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step03_ConditionsAndLoops
    {
        public static void Run()
        {
            int age = 20;

            // 조건문 if-else
            if (age >= 18)
            {
                Console.WriteLine("당신은 성인입니다.");
            }
            else
            {
                Console.WriteLine("당신은 미성년자입니다.");
            }

            // switch 조건문
            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("훌륭해요!");
                    break;
                case 'B':
                    Console.WriteLine("잘했어요!");
                    break;
                case 'C':
                    Console.WriteLine("아쉬워요..");
                    break;
                default:
                    Console.WriteLine("노력하세요..");
                    break;
            }

            // for 반복문
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"for 반복: {i}");
            }

            // while 반복문
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine($"while 반복: {count}");
                count++;
            }

            // do-while 반복문
            int doCount = 0;
            do
            {
                Console.WriteLine($"do-while 반복: {doCount}");
                doCount++;
            } while (doCount < 2);
        }
    }
}