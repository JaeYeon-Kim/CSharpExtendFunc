// /*
// - 소수 구하기
// - 특정 수를 입력 받아서, 소수인지 아닌지 판별하는 프로그램
// - 1과 자기 자신만을 약수로 갖는다 
// */


// class PrimeNumber
// {
//     static void Main(string[] args)
//     {
//         string inputString = Console.ReadLine();
//         int inputInt = int.Parse(inputString);
//         int measureCount = 0;

//         for (int i = 1; i <= inputInt; i++)
//         {
//             if (inputInt % i == 0)
//             {
//                 measureCount++;
//             }
//         }

//         if (measureCount == 2)
//         {
//             Console.WriteLine("소수다!");
//         }
//         else
//         {
//             Console.WriteLine("소수가 아니다!");
//         }
//     }
