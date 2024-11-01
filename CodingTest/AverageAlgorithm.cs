/*
평균 알고리즘 : 주어진 범위에 주어진 조건에 해당하는 자료들의 평균 
[?] n명의 점수 중에서 80점이상 95점 이하인 점수의 평균 
*/


// class AverageAlgorithm
// {
//     static void Main(string[] args)
//     {
//         int[] scoreData = { 90, 65, 78, 50, 95 };
//         int sum = 0;
//         int count = 0;

//         foreach (var score in scoreData)
//         {
//             if (score >= 80 && score <= 95)
//             {
//                 sum += score;
//                 count++;
//             }
//         }

//         // 평균 구하기 
//         Console.WriteLine($"평균은? {sum / (double)count}");

//     }
// }