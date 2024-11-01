// class DividerProblem
// {
//     static void Main(string[] args)
//     {
//         Solution solve = new Solution();
//         int[] testList = solve.solution([5, 9, 7, 10], 5);
//         foreach (var item in testList)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }


// public class Solution
// {
//     public int[] solution(int[] arr, int divisor)
//     {
//         List<int> numberList = new List<int>();

//         foreach (var number in arr)
//         {
//             // 나누어 떨어지면 
//             if (number % divisor == 0)
//             {
//                 numberList.Add(number);
//             }
//         }

//         // 만약 리스트가 비어있으면?
//         if (numberList.Count == 0)
//         {   
//             numberList.Add(-1);
//         }

//         numberList.Sort();

//         return numberList.ToArray();
//     }
// }