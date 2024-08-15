using System;


// // 발행자 클래스 

// /*
// 출력하고 싶은 자료형 마다 메서드 오버로딩을 구현해주어야 한다. 
// 반복작업을 줄이기 위해 제네릭 타입을 사용 해야 한다. 


// */
// class MainClass
// {

//     public static void Main(string[] args)
//     {
//         int[] intValues = { 1, 2, 3 };
//         double[] doubleValues = { 1.1, 2.2, 3.3 };

//         PrintValue <int> (intValues);
//         PrintValue <double> (doubleValues);
//     }

//     static void PrintValue<T>(T[] values)
//     {
//         foreach (var i in values)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }

