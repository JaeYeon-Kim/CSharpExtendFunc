// using System;
// using System.Runtime.CompilerServices;

// /*
// 호출자 : 메서드를 사용하는 주체 
// 1. CallerFilePathAttribute : 호출자를 포함한 소스 파일의 전체 경로 자료형 : String
// 2. CallerLineNumberAttribute : 메서드가 호출되는 소스 파일의 줄 번호: Integer
// 3. CallerMemberNameAttribute : 호출자의 메서드 이름이나 속성 이름 : String
// */

// class MainClass
// {
//     public static void Main(string[] args)
//     {
//         TraceMessage("메서드 호출");

//     }

//     private static void TraceMessage(string message,


//         [CallerMemberName] string memberName = "",
//         [CallerFilePath] string sourceFilePath = "",
//         [CallerLineNumber] int sourceLineNumber = 0)
//     {
//         Console.WriteLine("메시지: " + message);
//         Console.WriteLine("메서드 이름: " + memberName);
//         Console.WriteLine("메시지: " + sourceFilePath);
//         Console.WriteLine("메시지: " + sourceLineNumber);
//     }
// }
