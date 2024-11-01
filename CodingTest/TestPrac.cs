// using System;

// namespace CodingTest
// {
//     class TestPrac
//     {
//         static void Main(string[] args)
//         {
//             Solution solve = new Solution();
//             string result = solve.solution("205");
//             Console.WriteLine(result);
//         }
//     }



//     public class Solution
//     {
//         public string solution(string rsp)
//         {
//             // 가위는 2, 보는 5, 바위는 0 
//             string answer = "";
//             List<char> charList = new List<char>();
//             foreach (var item in rsp.ToCharArray())
//             {
//                 if (item.Equals('2'))
//                 {
//                     charList.Add('0');
//                 }
//                 else if (item.Equals('0'))
//                 {
//                     charList.Add('5');
//                 }
//                 else
//                 {
//                     charList.Add('2');
//                 }
//             }
//             answer = new string(charList.ToArray());
            
//             return answer;
//         }
//     }
// }