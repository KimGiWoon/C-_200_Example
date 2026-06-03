 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// 두 개의 배열을 쌍으로 정렬
namespace C__200_Example
{
    internal class Example_106
    {
        static void Main(string[] args)
        {
            string[] animalEnName = { "Dog", "Cow", "Rabbit", "Goat", "Sheep", "Mouse", "Horse", "Deer" };
            string[] animalKoName = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };

            // 정렬 전 배열 출력
            Display("Before Sort", animalEnName, animalKoName);

            // 영어를 기준으로 오름차순 정렬 후 출력
            Array.Sort(animalEnName, animalKoName);
            Display("After Sort by English", animalEnName, animalKoName);

            // 한글을 기준으로 오름차순 정렬 후 출력
            Array.Sort(animalKoName, animalEnName);
            Display("After Sort by Korean", animalEnName, animalKoName);

            IComparer revCom = new Reversecomparer();
            Array.Sort(animalEnName, animalKoName, revCom); // 영어 기준으로 내림차순 정렬
            Display("After Descending Sort by English", animalEnName, animalKoName);

            Array.Sort(animalKoName, animalEnName, revCom); // 한글 기준으로 내림차순 정렬
            Display("After Descending Sort by Korean", animalEnName, animalKoName);
        }

        // 배열 출력
        private static void Display(string comment, string[] enName, string[] koName)
        {
            Console.WriteLine(comment);

            for(int i = 0; i < enName.Length; i++)
            {
                Console.WriteLine($"[{i}] : {enName[i]}, {koName[i]}");
            }

            Console.WriteLine();
        }
    }

    class Reversecomparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);  // 내림차순 정렬
        }
    }
}
