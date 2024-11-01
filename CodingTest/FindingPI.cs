// /*
// 원주율: 원둘레와 지름의 비, 즉 원의 지름에 대한 둘레의 비율을 나타내는 수학 상수 
// */


// class Program
// {
//     public static void Main(string[] args)
//     {
//         bool sign = false;
//         double pi = 0;

//         for (int i = 0; i <= 10000; i += 2)
//         {
//             if (sign == false)
//             {
//                 pi += 1.0 / i;
//                 sign = true;
//             }
//             else
//             {
//                 pi -= 1.0 / i;
//                 sign = false;
//             }
//             Console.WriteLine("i = {0}, PI = {1}", i, 4 * pi);
//         }
//     }
// }