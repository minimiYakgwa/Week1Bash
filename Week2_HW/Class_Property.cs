using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_property
{
    /*
    public class Player
    {
        private int currentHP; // 프로퍼티 선언
        public int CurrentHP 
        {
            get => currentHP;
            set
            {
                if (value > 0)
                {
                    currentHP = value;
                }
                else
                {
                    currentHP = 0;
                }
            }
        }
    }
 //---------------------------------------------------------------------------------------
    public class Player
    {
        public int CurrentHP // 프로퍼티 자동 구현
        { get; set; } 
        
        public string ID
        {
            get;set;
        }
    }
 //----------------------------------------------------------------------------------------     
    public class Player
    {
        private int currentHP;
        public int CurrentHP // 읽기전용 프로퍼티 1
        {
            get => currentHP;
        }
    }
 //----------------------------------------------------------------------------------------
    public class Player
    {
        private int currentHP;
        public int CurrentHP // 현재 클래스 내부에서만 set 프로퍼티를 사용할 수 있음.
        {
            private set => currentHP = value;
            get => currentHP;
        }
    }
 //---------------------------------------------------------------------------------------
    public class Player
    {
        public int CurrentHP
        {
            get; set;
        }
        public string ID
        {
            get; set;
        }
    }
 //--------------------------------------------------------------------------------
        
    interface IBaseEntity // 인터페이스의 프로퍼티는 상속받은 클래스에서 재정의해야함.
        {
            string ID { get; set; }
            int Damage { get; set; }
            int CurrentHP { get; set; }
        }
    }*/
 //------------------------------------------------------------------------------
    public abstract class BaseEntity // 추상 클래스의 프로퍼티 구현
    {
        abstract public int Shield
        {
            get;set;
        }
        public int Defense
        {
            get;set;
        }
    }
    public class Player : BaseEntity
    {
        public override int Shield
        {
            get;set;
        }
        public string ID
        {
            get;set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.ID = "r";
            player.Shield = 3;
            player.Defense = 4;
            Console.WriteLine("ID : {0}", player.ID);
            Console.WriteLine("Shield : {0}", player.Shield);
            Console.WriteLine("Defense : {0}", player.Defense);
        }
    }
}
