using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Icomparable 인터페이스를 이용한 객체의 정렬
namespace C__200_Example
{
    class Artists : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth { get; set; }
        public int Die { get; set; }

        public Artists(string name, string country, int birth, int die)
        {
            Name = name;
            Country = country;
            Birth = birth;
            Die = die;
        }

        public int CompareTo(object? obj)
        {
            Artists artists = (Artists)obj;
            return this.Birth.CompareTo(artists.Birth); // 오름차순 정렬
            //return artists.Birth.CompareTo(this.Birth); // 내림차순 정렬
        }

        // class는 기본적으로 object를 상속 받는데 object에 Override로 만든 메서드로 WriteLine()하면 자동으로 Tostring()이 호출됨
        public override string ToString()
        {
            return string.Format($"{Name}, {Country}, {Birth}, {Die}");
        }
    }

    internal class Example_107
    {
        static void Main(string[] args)
        {
            Artists[] famousArtists =
            {
                new Artists("레오나르도 다빈치", "이탈리아", 1452, 1519),
                new Artists("빈센트 반 고흐", "네덜란드", 1853, 1890),
                new Artists("클로드 모네", "프랑스", 1840, 1926),
                new Artists("파블로 피카소", "스페인", 1881, 1973),
                new Artists("베르메르", "네덜란드", 1632, 1675),
                new Artists("르노아르", "프랑스", 1841, 1919)
            };

            List<Artists> artists19C = new List<Artists>();

            foreach(Artists artists in famousArtists)
            {
                // 19세기 예술가 구분
                if (artists.Birth > 1800 && artists.Birth <= 1900)
                {
                    artists19C.Add(artists);
                }
            }

            // IComparable를 사용하여 오름차순 정렬
            artists19C.Sort();

            Console.WriteLine("19세기 미술가를 탄생 순으로 오름차순 정렬 : IComparable 사용");

            foreach(Artists artists in artists19C)
            {
                Console.WriteLine(artists.ToString());
            }
        }
    }
}
