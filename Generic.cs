// using System;
// /*
// 일반화: 제네릭 메서드 혹은 제네릭 클래스 라고 한다 -> 코드의 중복을 최소화 하고자 설계 
// */

// class GenericClass<T>
// {
//     private T[] values;
//     private int count;

//     public GenericClass(int length)
//     {
//         values = new T[length];
//         count = length;
//     }
//     public void SetValue(T item, int index)
//     {
//         this.values[index] = item;
//     }

//     public void PrintValue()
//     {
//         foreach (T item in values)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// class MainClass
// {
//     public static void Main(string[] args)
//     {
//         GenericClass<int> intArray = new GenericClass<int>(3);
//         GenericClass<double> doubleArray = new GenericClass<double>(3);

//         intArray.SetValue(1, 0);
//         intArray.SetValue(2, 1);
//         intArray.SetValue(3, 2);
//         intArray.PrintValue();

//         doubleArray.SetValue(1.1 , 0);
//         doubleArray.SetValue(2.2, 1);
//         doubleArray.SetValue(3.3, 2);
//         doubleArray.PrintValue();
//     }
// }


