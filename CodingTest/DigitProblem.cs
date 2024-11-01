// class DigitProblem
// {
//     static void Main(string[] args)
//     {
//         Solution solve = new Solution();
//         long test = solve.solution(118372);
//         Console.WriteLine(test);
//     }
// }


// public class Solution
// {
//     public long solution(long n)
//     {
//         List<long> numberList = new List<long>();
//         long answer = 0;

//         while (n > 0)
//         {
//             answer = n % 10;
//             numberList.Add(answer);
//             n /= 10;
//         }

//         // 구한 배열 내림차순 
//         numberList.Sort((x, y) => y.CompareTo(x));

//           // 정렬된 숫자를 문자열로 변환
//         string result = string.Join("", numberList);

//         return long.Parse(result);// 결과 반환
//     }
// }