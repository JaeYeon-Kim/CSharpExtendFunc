using System.ServiceModel;
using System.ServiceModel.Channels;

class Descending
{
    static void Main(string[] args)
    {
        Solution solve = new Solution();
        solve.solution("zbcdefg");
    }
}

public class Solution
{
    public void solution(string s)
    {
        List<int> numberList = new List<int>();
        char[] characters = s.ToCharArray();

        foreach (char c in characters)
        {
            Console.WriteLine(c);   
        }
    }
}