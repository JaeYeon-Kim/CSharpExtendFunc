// using System;

// class DontExist
// {
//     static void Main(string[] args)
//     {
//         Solution solve = new Solution();
//         int testNumber = solve.solution([1, 2, 3, 4, 6, 7, 8, 0]);
//         Console.WriteLine(testNumber);
//     }
// }



// public class Solution
// {
//     public int solution(int[] numbers)
//     {
//         int answer = 0;
//         int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9};

//         foreach (var number in testArray)
//         {
//             var isExist = Array.Exists(numbers, x => x == number);
//             Console.WriteLine(isExist);
//             Console.WriteLine(number);

//             if (!isExist)
//             {
//                 answer += number;
//             }
//         }

//         return answer;
//     }
// }