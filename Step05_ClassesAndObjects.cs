using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step05_ClassesAndObjects
    {
        public static void Run()
        {
            // 객체 생성
            Person person1 = new Person();
            person1.Name = "Minseok";
            person1.Age = 25;
            person1.Introduce();

            Person person2 = new Person()
            {
                Name = "Dave",
                Age = 25
            };
            person2.Introduce();
        }
    }

    internal class Person
    {

        // 필드, 속성
        public string Name;
        public int Age;

        // 메서드
        public void Introduce()
        {
            Console.WriteLine($"안녕하세요, 제 이름은 {Name}이고, 나이는 {Age}살입니다.");
        }
    }
}
