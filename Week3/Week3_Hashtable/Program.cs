using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_HW_Hashtable
{
    public class HashTableExercise
    {
        public static void Awake()
        {
            Hashtable hash = new Hashtable();

            Goblin goblin = new Goblin();
            Slime slime = new Slime();

            hash["Goblin"] = goblin;

            hash.Add("Slime", slime);
            hash.Add(1, "정수");
            hash.Add(1.2f, "실수");
            hash.Add("안녕하세용", "문자열");

            foreach(object key in hash.Keys)
            {
                Console.WriteLine("hash[{0}] = {1}", key, hash[key]);
            }

            if (hash.ContainsKey("Slime"))
            {
                Console.WriteLine("Slime 키 존재함");
            }
            
            if (hash.ContainsValue(goblin))
            {
                Console.WriteLine("goblin 값 존재");
            }

            Console.WriteLine("Hashtable Count : {0}", hash.Count);

            hash.Remove("Slime");

            Console.WriteLine("Hashtable Count : {0}", hash.Count);

            hash.Clear();

            Console.WriteLine("Hashtable Count : {0}", hash.Count);


        }
    }

    public class Goblin { }
        public class Slime { }
    class Program
    {
        static void Main(string[] args)
        {
            HashTableExercise.Awake();
        }
    }
}
