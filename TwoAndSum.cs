// using System.Globalization;
// using System;
// using System.Linq;

// namespace CodingTest
// {
//     class TwoAndSum
//     {
//         static void Main(string[] args)
//         {
//             Solution solve = new Solution();
//             int[] result = [5, 0, 2, 7];
//             int[] resultArray = solve.solution(result);
//             foreach (var item in resultArray)
//             {
//                 Console.Write(item + " ");
//             }
//         }
//     }


//     public class Solution
//     {
//         public int[] solution(int[] numbers)
//         {
//             List<int> answer = new List<int>();

//             int resultIndex = 0;

//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 for (int j = i + 1; j < numbers.Length; j++)
//                 {
//                     answer.Add(numbers[i] + numbers[j]);
//                     resultIndex++;
//                 }
//             }

//             answer.Sort();

//             return answer.Distinct().ToArray();
//         }
//     }
// }