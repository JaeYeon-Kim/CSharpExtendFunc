/*
- 대리자와 이벤트 
*/



class SubScriber
{
    public SubScriber()
    {
        Publisher.myEvent += TestMethod;
    }

    public void TestMethod()
    {
        Console.WriteLine("이벤트 메서드 호출!!");
    }
}

class Publisher
{
    public static event myEventHandler myEvent;

    public void RunEvent()
    {
        myEvent();
    }
}