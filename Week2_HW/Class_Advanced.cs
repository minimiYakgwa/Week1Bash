using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_advanced
{
/*//---------------------------------------------------정보 은닉
    public class Player
    {
        private int currentHP;

        public void SetCurrentHP(int hp)
        {
            if (hp > 0)
            {
                currentHP = hp;
            }
        }

        public int GetCurrentHP()
        {
            return currentHP;
        }
    }
    //------------------------------------------------------------- 상속, base(부모 클래스의 멤버변수를 사용함.) 
    public class Entity
    {
        public string ID;
        protected int currentHP;

        private void initialize()
        {
            
        }

        public void RecoveryHP(int hp)
        {
            currentHP += hp;
        }

        

    }
    public class Player : Entity
    {
        private string ID;
        public Player(string id, int hp)
        {
            base.ID = "Noname";
            ID = id;
            currentHP = hp;

            RecoveryHP(1000);

            // Initialize(); // private이므로 사용불가
        }
        
    }
//---------------------------------------------------------------------------- 생성자, 소멸자
    public class Entity
    {
        public Entity() { }
        ~Entity() { }
    }
//---------------------------------------------------------------------------- 다형성
    public  class Entity
    {
        public void Attack() { }
        public void Heal() { }
    }
    public class Goblin : Entity
    {
        public void Avoid() { }
        public void Heal() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            private Entity entity = new Entity(); // Entity요소만 사용가능
            private Goblin goblin = new Goblin(); // Goblin요소와 Entity요소 사용가능. 동일한 메소드 존재시 자식 클래스의 메소드 호출.
            private Entity entity2 = new Goblin(); // Entity요소만 사용가능. 동일한 메소드 존재시 부모 클래스의 메소드 호출.(업케스팅으로 불림)
    }
}
//----------------------------------------------------------------------------------  메소드 오버라이딩
    public class Entity
    {
        public virtual void Attack() { }
    }
    
    public class Slime : Entity
    {
        public override void Attack() { }
    }
//-------------------------------------------------------------------------------------- 클래스 형변환
    public class Entity
    {

    }

    public class Goblin : Entity
    {
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            private Entity entity = new Goblin(); // 업케스팅 가능
            private Entity entity2 = new Goblin();
            private Goblin goblin = (Goblin)entity2; // 업케스팅 한 요소를 다운캐스팅할 수 있음.
            private Entity entity3 = new Entity();
            private Goblin goblin2 = (Goblin) entity3; //그냥 다운캐스팅은 불가능. 인스턴스가 사용할 멤버가 더 많아지기 때문.
        }
    }
//------------------------------------------------------------------------------------------------is, as
    public class Entity
    {
        
    }
    public class Goblin : Entity
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Entity entity = new Entity();
            if(entity is Goblin) // 형변환이 가능하면 true반환
            {
                Console.WriteLine("Entry type is Goblin");
            }
            Goblin goblin = entity as Goblin; // 형변환에 실패하면 null반환
           
        }
    }
//-----------------------------------------------------------------------------------------------------추상 클래스
    public abstract class Entity
    {
        protected int damage;
        protected int currentHP;
        public abstract void Attack(Entity target);
    }
    public class Goblin : Entity
    {
        public override void Attact(Entity target) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            private Entity entity; // 추상 클래스는 인스턴스 생성이 안됨.
    private Goblin goblin;
        }
    }
//--------------------------------------------------------------------------------------------인터페이스
    interface IMovingEntity
    {
        void MoveTo();
    }
    public class Goblin : IMovingEntity
    {
        public void MoveTo() { }
    }
//--------------------------------------------------------------------------------------------- 인터페이스를 상속하는 인터페이스
    interface IMovingEntity
    {
        void MoveTo();
    }
    interface IPerson : IMovingEntity
    {
        void Talk(string word) 
    }

    public class Goblin : IPerson
    {
        public void MoveTo() { }
        public void Talk(string word) { }
}
//--------------------------------------------------------------------------------------------- 인터페이스 다중 상속
    interface IMovingEntity
    {
        void MoveTo();
    }
    interface IM2
    {
        void TT();
    }
    public Goblin : IMovingEntity, IM2
    {
        public void MoveTo() { }
        public void TT() { }
    }
*/
}


