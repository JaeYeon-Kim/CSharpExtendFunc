// /*
// 평균, 최소, 최댓값 구하기
// */


// using System.Globalization;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         double max = double.MinValue;
//         double min = double.MaxValue;
//         double sum = 0;

//         for (int i = 0; i < 5; i++)
//         {
//             Console.Write("키를 입력하세요(단위: cm)");
//             double h = double.Parse(Console.ReadLine());
//             if (h > max)
//             {
//                 max = h;
//             }
//             else if (h < min)
//             {
//                 min = h;
//             }
//             sum += h;
//         }
//         Console.WriteLine("평균 {0}cm, 최대 : {1}cm, 최소: {2}cm", sum / 5, max, min);
//     }
// }