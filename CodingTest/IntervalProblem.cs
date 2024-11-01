// using System.Media;

// class IntervalProblem
// {
//     static void Main(string[] args)
//     {
//         Solution solve = new Solution();
//         long[] testArray = solve.solution(x: 2, n: 5);
//         foreach (var item in testArray)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// public class Solution
// {
//     public long[] solution(int x, int n)
//     {
//         List<long> numberList = new List<long>();
//         for (int i = 1; i <= n; i++)
//         {
//             numberList.Add(x * i);
//         }

//         return numberList.ToArray();
//     }
// }