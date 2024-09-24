using System.Drawing;
using System.Runtime.InteropServices.Marshalling;

class Substring
{
    static void Main(string[] args)
    {
        Solution solve = new Solution();
        string test = solve.solution("qwer");
        Console.WriteLine(test);
    }
}

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        // 짝수일 경우 
        if (s.Length % 2 == 0)
        {
            answer = s.Substring((s.Length / 2) - 1, 2);
        }
        else    // 홀수 일 경우 
        {
            answer = s.Substring(s.Length / 2, 1);
        }
        return answer;
    }
}