using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_CSharp
{
    internal class StepPractice_MemberManager
    {
        public static void Run()
        {
            bool isRunning = true;
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
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n[잘못된 입력입니다. 숫자만 입력해주세요.]\n");
                    continue;
                }

                if (choice == 1)
                {
                    Console.WriteLine("\n[1. 회원 추가]");
                    Console.Write("이름을 입력하세요: ");
                    string name = Console.ReadLine();

                    Console.Write("나이를 입력하세요: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("\n[나이는 숫자로 입력해주세요.]\n");
                        continue;
                    }

                    members.Add(new Member(name, age));
                    Console.WriteLine("\n회원이 추가되었습니다.\n");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n[2. 전체 회원 보기]");
                    if (members.Count == 0)
                    {
                        Console.WriteLine("등록된 회원이 없습니다.");
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            Console.WriteLine(member.Name);
                        }
                    }
                    Console.WriteLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n[3. 성인 회원만 보기 (18세 이상)]");
                    var adultMembers = members.Where(m => m.Age >= 18).ToList();

                    if (adultMembers.Count == 0)
                    {
                        Console.WriteLine("성인 회원이 없습니다.");
                    }
                    else
                    {
                        foreach (var member in adultMembers)
                        {
                            Console.WriteLine(member.Name);
                        }
                    }
                    Console.WriteLine();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\n[4. 이름으로 검색]");
                    Console.Write("키워드를 입력하세요: ");
                    string keyword = Console.ReadLine();

                    var foundMembers = members
                        .Where(m => m.Name.ToLower().Contains(keyword.ToLower()))
                        .ToList();

                    if (foundMembers.Count == 0)
                    {
                        Console.WriteLine("검색 결과가 없습니다.");
                    }
                    else
                    {
                        foreach (var member in foundMembers)
                        {
                            Console.WriteLine(member.Name);
                        }
                    }
                    Console.WriteLine();
                }
                else if (choice == 0)
                {
                    Console.WriteLine("\n[0. 종료]");
                    Console.WriteLine("이용해주셔서 감사합니다.");
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("\n[잘못된 입력입니다]\n");
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
