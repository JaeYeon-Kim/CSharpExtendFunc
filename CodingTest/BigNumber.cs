// using System;

// namespace BigNumber
// {
//     class CodingTest
//     {
//         static void Main(string[] args)
//         {
//             Solution solve = new Solution();
//             int result = solve.solution(15);
//             Console.WriteLine(result);
//         }
//     }




//     class Solution
//     {
//         public int solution(int n)
//         {
//             int answer = n + 1;
//             int countOne = ConvertToBinaryNumber(n);
//             while (ConvertToBinaryNumber(answer) != countOne)
//             {
//                 answer++;
//             }

//             return answer;
//         }

//         public int ConvertToBinaryNumber(int number)
//         {
//             string binaryNumber = Convert.ToString(number, 2);
//             int countOne = binaryNumber.Split('1').Length - 1;
//             return countOne;
//         }
//     }
// }