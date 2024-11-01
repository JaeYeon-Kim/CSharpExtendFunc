// /*
// Nullable 값 형식
// 자료형에 null 값을 넣을 수 있도록 허용 
// */

// class MainClass
// {
//     public static void Main(string[] args)
//     {
//         int? var1 = 10;
//         int var2 = 15;
//         Console.WriteLine(IsOfNullableType(var1));
//         Console.WriteLine(IsOfNullableType(var2));
//     }

//     static bool IsOfNullableType <T> (T o) {
//         var type = typeof (T);
//         return Nullable.GetUnderlyingType(type) != null;
//     }
// }