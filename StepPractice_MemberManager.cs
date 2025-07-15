using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_CSharp
{
    internal class StepPractice_MemberManager
    {
        public static void Run()
        {

            Boolean isRunning = true;

            List<Member> members = new List<Member>();

            while (isRunning)
            {
                Console.WriteLine("==== 회원 관리 프로그램 ====");
                Console.WriteLine("1. 회원 추가");
                Console.WriteLine("2. 전체 회원 보기");
                Console.WriteLine("3. 성인 회원만 보기 (18세 이상)");
                Console.WriteLine("4. 이름으로 검색");
                Console.WriteLine("0. 종료");

                Console.Write("\n숫자를 선택하세요: ");
                int choice = int.Parse(Console.ReadLine()); // 예외 처리 필수이긴 한데 아직 익숙하지 않음

                if (choice == 1)
                {
                    Console.WriteLine("\n[1. 회원 추가]");
                    Console.Write("이름을 입력하세요: ");
                    string name = Console.ReadLine();
                    Console.Write("나이를 입력하세요: ");
                    int age = int.Parse(Console.ReadLine());
                    members.Add(new Member(name, age));
                    Console.WriteLine("\n");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n[2. 전체 회원 보기]");
                    foreach (var member in members)
                    {
                        Console.WriteLine(member.Name);
                    }
                    Console.WriteLine("\n");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n[3. 성인 회원만 보기 (18세 이상)]");
                    List<Member> adultMembers = members.Where(m => m.Age >= 18).ToList(); // 이거는 chatGPT 도움 받음..
                    foreach (var member in adultMembers)
                    {
                        Console.WriteLine(member.Name);
                    }
                    Console.WriteLine("\n");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\n[4. 이름으로 검색]");
                    Console.Write("키워드를 입력하세요: ");
                    string keyword = Console.ReadLine();
                    List<Member> isContainedMembers = members.Where(m => m.Name.Contains(keyword.ToLower())).ToList(); // 이것도 chatGPT 도움 받음..
                    foreach (var member in isContainedMembers)
                    {
                        Console.WriteLine(member.Name);
                    }
                    Console.WriteLine("\n");
                }
                else if (choice == 0)
                {
                    Console.WriteLine("\n[0. 종료]");
                    Console.WriteLine("이용해주셔서 감사합니다.");
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("\n[잘못된 입력입니다]");
                    Console.WriteLine("\n");
                    continue;
                }
            }
        }
    }

    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}