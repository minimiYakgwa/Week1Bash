using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_basic_trainning
{
    public class Character
    {
        private int power = 1;
        private int hit_rate = 50;
        private int crit_rate = 0;
        private int crit_damage = 50;

        public Character(string job = null) // 생성자
        {
            switch (job)
            {
                case "Worrier":
                    this.power += 29;
                    break;
            }
        }
        public Character Feature_copy()
        {
                Character clone = new Character("Worrier");
                clone.power = this.power;
                clone.hit_rate = this.hit_rate;
                clone.crit_rate = this.crit_rate;
                clone.crit_damage = this.crit_damage; // this 키워드
                return clone;
        }

        public void Show_feature()
        {
            Console.WriteLine("Power : {0}", power);
            Console.WriteLine("Hit_rate : {0}", hit_rate);
            Console.WriteLine("Crit_rate : {0}", crit_rate);
            Console.WriteLine("Crit_damage : {0}", crit_damage);
        }

        ~Character() { } // 소멸자
    }
    class Program
    {
        static void Main(string[] args)
        {
            Character p1 = new Character("Worrier");
            Character p2 = p1.Feature_copy(); // 깊은 복사
            p1.Show_feature();
            p2.Show_feature();
        }
    }
}
