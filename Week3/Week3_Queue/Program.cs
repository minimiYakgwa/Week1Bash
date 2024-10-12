using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_HW2
{
    public class QueueExercise
    {
        public static void Awake()
        {
            Queue queue = new Queue();
            for (int i = 0; i< 5; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("Queue Count : {0}", queue.Count);

            Console.WriteLine("Queue의 0번째 요소 : {0}", queue.Peek()); // 앞 요소를 삭제하지 않고 반환함.

            Console.WriteLine("Queue Count : {0}", queue.Count);

            Console.WriteLine("Queue에서 나온 데이터 : {0}", queue.Dequeue()); // 앞 요소를 삭제하고 반환함.

            Console.WriteLine("Queue Count : {0}", queue.Count);

            queue.Clear();

            Console.WriteLine("Queue Count : {0}", queue.Count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QueueExercise.Awake();
        }
    }
}
