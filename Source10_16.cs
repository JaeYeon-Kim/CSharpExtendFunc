// using System;

// /*
// 명명된 매개변수와 선택적 매개변수 
// 매개변수는 일반적으로 순서에 따라 결정 
// */

// class Person
// {
//     private string name;
//     private int age;
//     private string gender;

//     public Person(string name, int age, string gender)
//     {
//         this.name = name;
//         this.age = age;
//         this.gender = gender;
//     }

//     public void PrintPerson()
//     {
//         Console.WriteLine("이름: " + this.name);
//         Console.WriteLine("나이: " + this.age);
//         Console.WriteLine("성별: " + this.gender);
//     }
// }

// class MainClass
// {
//     public static void Main(string[] args)
//     {
//         Person y = new Person("영희", 20, "여");
//         y.PrintPerson();

//         Person c = new Person("남", 20, "철수");
//         c.PrintPerson();
//     }
// }

