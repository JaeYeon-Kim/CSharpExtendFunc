// /*
// 개수 알고리즘(Count Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 개수  
// [?] 1부터 1000까지의 정수 중 13의 배수의 개수는 몇개인가?
// */
// using System;
// using System.Linq;

// class CountAlgorithm
// {
//     static void Main(string[] args)
//     {

//         // [1] Input
//         var numbers = Enumerable.Range(1, 1_000).ToArray();
//         int count = 0;

//         // [2] Process
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 13 == 0)
//             {
//                 count++;
//             }
//         }
//     }
// }