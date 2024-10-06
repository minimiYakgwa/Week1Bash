using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Class_Additive_Function
{

//---------------------------------------------- 메소드 숨기기
    public class Parent
    {
        public void Method01()
        {
            Console.WriteLine("Parent");
        }
    }
    public class Child : Parent
    {
        public new void Method01() // 부모클래스를 자식클래스로 업캐스팅 할 때, 같은 이름의 메소드 중 new를 사용한 자식클래스 메소드는 숨겨짐. 
        {
            Console.WriteLine("Child");
        }
    }
//---------------------------------------------------------------------------------- 오버라이딩 봉인
    public class Entity
    {
        public virtual void TakeDamege(int damage)
        {
            Console.WriteLine("Entity : {damage}만큼 체력 감소함.");
        }
    }

    public class MovingEntity : Entity
    {
        public sealed override void TakeDamege(int damage)
        {
            Console.WriteLine("Entity : {damage}만큼 체력 감소");
        }
    }

    public class Player : MovingEntity
    {
        public override void TakeDamege(int damage) //부모 클래스의 메소드가 오버라이딩이 안됨.
        {
            Console.WriteLine("Entity: { damage}만큼 체력 감소");
        }
    }
//---------------------------------------------------------------------------------------------- 중첩 클래스
  
    public class OuterClass
    {
        private int a;
        public class InnerClass
        {
            a += 1; // 클래스 안의 클래스는 private 요소들에게 접근이 가능하게 된다.
        }
    }
//------------------------------------------------------------------------ 분할 클래스 : 하나의 클래스를 여러 파일에 나눠 구현하는 것.
    public partial class Player // 클래스명과 동일한 파일이 반드시 한개 존재해야하고 컴포넌트로 사용할 땐 클래스명과 같은 파일을 추가.
    {
        public void CounterAttact() { }
    }

//------------------------------------------------------------------------ 구조체 : 참조식인 클래스와 달리 값형식임. new를 사용하면 변수 초기화됨.
    public struct Stats
    {
        public string ID;
        public int currentHP;
        public int damage;
    } 
//---------------------------------------------------------------------------- static method, static class
    public static class Enemy
    {
        public static int numberic; // 실행 시 한번만 생성됨.
        public static void StaticRun()
        {
            Console.WriteLine("StaticRun");
        }
        static Enemy() // static class의 생성자는 static [class명]형태로 작성해야함.
        {

        }
    }
//-----------------------------------------------------------------------------------확장 메소드
    public static class StringExtension
    {
        public static void PrintData(this string str)
        {
            Console.WriteLine(str);
        }
    }
 //-------------------------------------------------------------------------------------튜플
     class Program
    {
        static void Main(string[] args)
        {
            var a = ("3", 2);  튜플
            Debug.Log($"{a.item1}, {a.item2}");
            a.Item2 = 36;
            var b = (name: "321", age: 3);
            var (name, age) = b;
            Debug.Log($"{name}, {age}");
            var(name, ) = b;
            Debug.Log($"{name}");
        }
    }
}*/

//---------------------------------------------------------------------------------------이름 공간(비슷한 일을 하는 코드끼리 묶음)
namespace Myspace
{
    public class Player
    {

    }
}
namespace YourSpace
{
    public class Player
    {

    }
}

namespace Ourspace
{
    using Myspace; // 둘 다 선언할 때 동일한 요소가 있으면 오류 발생.
    class Program
    {
        static void Main(string[] args)
        {
            Player player;
            YourSpace.Player player2;
        }
    }
    
}
        
  
