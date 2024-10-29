namespace CodingTest
{
    class SumOfMeasure
    {
        static void Main(string[] args)
        {
           Solution solve = new Solution();
           var result = solve.solution(5);
           Console.WriteLine("약수의 합은? " + result);
        }
    }

    public class Solution
    {
        public int solution(int n)
        {
            // 약수의 합 
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}