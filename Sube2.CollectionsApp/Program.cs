using System.Collections;

namespace Sube2.CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //int s1 = 5;
            //int s2 = 10;

            //al.Add(s1);//Boxing Değer tipinin->Object
            //al.Add(s2);
            //al.Add(1);
            //al.Add(2);
            //al.Add(3);

            //al.Capacity = al.Count;
            //Console.WriteLine($"Capacity:{al.Capacity}\nCount:{al.Count}");


            //Console.WriteLine((int)al[0] + (int)al[1]);//Unboxing

            //var d = new Deneme<int,string>();
            //d.value1 = 1;
            //d.value2 = "2";           

            Dictionary<string,string> sozluk=new Dictionary<string,string>();
            sozluk.Add("06", "Ankara");

        }
    }

    class Deneme<T, U> where T : struct
                        where U : class
    {
        public T value1;
        public U value2;

        public void Yazdir(T value)
        {
            Console.WriteLine(value);
        }
    }
}
//Generic Constraints