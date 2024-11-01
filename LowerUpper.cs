using System;

namespace CodingTest
{
    class LowerUpper
    {
        static void Main(string[] args)
        {
            Solution solve = new Solution();
            var result = solve.solution("cccCCC");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            foreach (var word in my_string.ToCharArray())
            {
                // 대문자
                if (char.IsUpper(word))
                {
                    answer += char.ToLower(word);
                }

                // 소문자 
                else if (char.IsLower(word))
                {
                    answer += char.ToUpper(word);
                }
            }
            return answer;
        }
    }
}