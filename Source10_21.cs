// using System;
// using System.Threading.Tasks;

// class MainClass
// {
//     public static async Task Main(string[] args)
//     {
//         Task<string> t = AsyncFunc();
//         Console.WriteLine("1");
//         string value = await t;
//         Console.WriteLine("2");
//         Console.WriteLine(value);
//         Console.Read();
//     }


//     public static async Task<String> AsyncFunc()
//     {
//         await Task.Delay(2000);
//         Console.WriteLine("3");
//         return "Hello";
//     }
// }