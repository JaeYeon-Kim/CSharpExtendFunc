using System;


/*
Event Handler
*/


delegate void myEventHandler();
// 발행자 클래스 
class MainClass
{

    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        SubScriber sub = new SubScriber();
        publisher.RunEvent();
    }
}

