using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step08_LINQBasic
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 3, 7, 2, 10, 5, 8 };

            // 1. Where : 필터링
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("짝수 목록 : ");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            // 2. Select : 변환
            var squared = numbers.Select(n => n * n);

            Console.WriteLine("\n제곱한 값 목록 : ");
            foreach (var n in squared)
            {
                Console.WriteLine(n);
            }

            // 3. OrderBy / OrderByDescending : 정렬
            var sorted = numbers.OrderBy(n => n);

            Console.WriteLine("\n오름차순 정렬 : ");
            foreach (var n in sorted)
            {
                Console.WriteLine(n);
            }

            // 4. Any / ALL : 조건 검사
            Console.WriteLine($"\n모두 10 이상인가? {numbers.All(n => n >= 10)}");
            Console.WriteLine($"하나라도 5보다 큰 수가 있나? {numbers.Any(n => n > 5)}");

            // 5. First / FirstOrDefault
            Console.WriteLine($"첫 번째 짝수 : {numbers.First(n => n % 2 == 0)}");

            // 6. 복합 쿼리
            var result = numbers
                .Where(n => n > 4)
                .OrderByDescending(n => n)
                .Select(n => $"값 : {n}");

            Console.WriteLine("\n복합 쿼리 결과: ");
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
