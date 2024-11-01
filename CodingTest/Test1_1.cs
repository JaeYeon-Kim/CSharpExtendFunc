// using System;
// using System.Reflection.Metadata;
// using System.Runtime.CompilerServices;
// using System.Runtime.InteropServices;
// using System.Xml.XPath;
// using Microsoft.VisualBasic;

// namespace Test1_1
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /*
//             object 타입과 박싱, 언박싱
//             값 형식의 변수가 object 타입으로 변환되는 것을 박싱(boxing)
//             object 타입의 변수가 값 형식으로 변환되는 것을 언박싱 (unboxing)
//             */
//             int i = 123;
//             object o = i;       // i의 값을 박싱하여 o로 복사 
//             i = i + 10;     // i의 값을 바꿉니다. o는 변하지 않음 
//             int j = (int)o; // o의 값을 언박싱하여 j로 복사 
            
//             Console.WriteLine("The value - type value i = {0}", i);
//             Console.WriteLine("The value - type value o = {0}", o);
//             Console.WriteLine("The value - type value j = {0}", j);

//             object p = o;
//             o = 100;

//             Console.WriteLine("The object-type value o = {0}", o);
//             Console.WriteLine("The object-type value p = {0}", p);
//         }
//     }
// }