using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class Step06_Constructors
    {
        public static void Run()
        {
            // 생성자 사용해서 객체 생성
            PersonCon p1 = new PersonCon("Mina", 25);
            p1.Introduce();

            PersonCon p2 = new PersonCon("Joon", 31);
            p2.Introduce();
        }
    }

    class PersonCon
    {
        // 속성 (field)
        public string Name;
        public int Age;

        // 생성자
        public PersonCon(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // 메서드
        public void Introduce()
        {
            Console.WriteLine($"안녕하세요, 저는 {Name}이고 나이는 {Age}살입니다.");
        }


    }
}
