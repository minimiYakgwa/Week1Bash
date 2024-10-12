using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Week3_HW
{
    public class ArrayListEercise
    {
        public static void Awake()
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine(arrayList.Add(10));

            foreach(int s in arrayList)
            {
                Console.WriteLine(s);
            }

            arrayList.Insert(1, 100); // 1번 위치에 값 100 추가 

            foreach(int s in arrayList)
            {
                Console.WriteLine(s);
            }

            Collection<int> data = new Collection<int>();
            data.Add(1);
            data.Add(2);
            data.Add(3);
            arrayList.AddRange(data);

            foreach(int s in arrayList)
            {
                Console.WriteLine(s);
            }

            arrayList.Sort(); // 정수값에 대해서만 정렬가능.

            foreach(int s in arrayList)
            {
                Console.WriteLine(s);
            }

            arrayList.Remove(10); // 10인 값 삭제

            foreach (int s in arrayList)
            {
                Console.WriteLine(s);
            }

            arrayList.RemoveAt(0); // 0번 인덱스의 값 삭제

            foreach (int s in arrayList)
            {
                Console.WriteLine(s);
            }

            arrayList.RemoveRange(0, 2); // 첫 번째 매개변수 위치부터 두 번째 매개변수 개수만큼 삭제

            foreach (int s in arrayList)
            {
                Console.WriteLine(s);
            }

            arrayList.Clear();

            Console.WriteLine(arrayList.Count);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListEercise.Awake();
        }
    }
}
