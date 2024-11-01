// /*
// 등차수열: 연속하는 두 수의 차이가 일정한 수열 

// 1부터 20까지의 정수 중 홀수의 합을 구하는 프로그램 
// */


// class ArithmmeticSequence
// {
//     static void Main(string[] args)
//     {
//         // [1] Input
//         var sum = 0;

//         // [2] Process
//         for (int i = 0; i < 20; i++)    // 범위 
//         {
//             if (i % 2 != 0)     // 필터링 홀수 
//             {
//                 sum += i;
//                 Console.Write("{0, 2} ", i);
//             }
//         }


//         // [3] Output
//         Console.WriteLine($"\n1부터 20까지의 홀수의 합: {sum}");
//     }
// }