// class Program
// {
//     static void Main(string[] args)
//     {

//     }
// }

// public class Player
// {
//     // 멤버 변수: 클래스에 소속된 변수로 클래스의 속성을 저장, 사용하기 위한 용도 
//     private string id = "고박사";
//     private int currentHp = 1000;

//     private void CallDamage()
//     {
//         TakeDamage(30);     // 같은 클래스에 소속되어 있는 메소드끼리는 조건없이 호출 가능 
//     }

//     public void TakeDamage(int damage)
//     {
//         if (currentHp > damage)
//         {
//             currentHp -= damage;
//         }

//     }
// }


// public class Enemy
// {
//     private Player player;

//     public void AttackToTarget(Player target)
//     {
//         target.TakeDamage(100);
//     }
// }

// public class GameController
// {
//     private void Awake()
//     {
//         Player01 
//     }
// }