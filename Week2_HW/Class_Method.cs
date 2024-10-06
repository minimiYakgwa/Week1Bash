using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_trainning
{
    public class Character_feature
    {
        protected int power = 1;
        protected int magic = 1;
        protected int speed = 1;
        protected int luck = 1;
        protected int hit_rate = 1 ;
        protected int cri_rate = 0;
        protected int cri_damage = 50;

        public void Print_feature() // 메소드
        {
            Console.WriteLine("Power : {0}", power);
            Console.WriteLine("Magic : {0}", magic);
            Console.WriteLine("Speed : {0}", speed);
            Console.WriteLine("Luck : {0}", luck);
            Console.WriteLine("Hit_rate : {0}", hit_rate);
            Console.WriteLine("Cri_rate : {0}%", cri_rate);
            Console.WriteLine("Cri_damage : {0}%", cri_damage);
        }

        public void SetFeature(string feature, int num = 0) // 선택적 매개변수
        {
            switch (feature)
            {
                case "power":
                    this.power += num;
                case "magic":
                    this.magic += num;
                case "speed":
                    this.speed += num;
                case "luck":
                    this.luck += num;
                case "hit_rate":
                    this.hit_rate += num;
                case "cri_rate":
                    this.cri_rate += num;
                case "cri_damage":
                    this.cri_damage += num;
            }
        }

        public int GetFeature(string feature) // return 
        {
            switch (feature)
            {
                case "power":
                    return power;
                case "magic":
                    return magic;
                case "speed":
                    return speed;
                case "luck":
                    return luck;
                case "hit_rate":
                    return hit_rate;
                case "cri_rate":
                    return cri_rate;
                case "cri_damage":
                    return cri_damage;
            }
        }

    }

    public class Worrier : Character_feature
    {
        public Worrier()
        {
            this.power += 29;
        }
    }

    public class thief : Character_feature
    {
        public thief()
        {
            this.luck += 29;
            this.speed += 19;
        }
    }

    public static class Cal
    {
        public static void Swap(ref int x, ref int y) // 참조에 의한 전달.
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        public static void Sum(params int[] nums) // 가변길이 매개 변수
        {
            int sum = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            thief C1 = new thief();
            C1.Print_feature();
            C1.SetFeature(feature: "speed") // 명명된 매개변수, 선택적 매개변수 사용
            Cal.Sum(1, 2, 3, 4);
        }
    }
}
