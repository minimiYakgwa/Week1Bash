using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_HW_Stack
{
    public class StackExercise
    {
        public static void Awake()
        {
            Stack stack = new Stack();

            for( int i =0; i < 5; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("Stack Count : {0}", stack.Count);

            Console.WriteLine("Stack에 마지막으로 추가된 요소 : {0}", stack.Peek());

            Console.WriteLine("Stack Count : {0}", stack.Count);

            Console.WriteLine("Stack Count : {0}", stack.Count);

            Console.WriteLine("Stack에서 나온 데이터 : {0}", stack.Pop());

            Console.WriteLine("Stack Count : {0}", stack.Count);

            stack.Clear();

            Console.WriteLine("Stack Count : {0}", stack.Count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StackExercise.Awake();
        }
    }
}
