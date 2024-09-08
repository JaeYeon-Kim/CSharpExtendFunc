/*
합계 알고리즘 
*/


class SumAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Input: n명의 국어 점수 
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        
        int sum = 0;

        // [2] Process: 합계 알고리즘 영역: 주어진 범위에 주어진 조건 
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] >= 80)
            {
                sum += scores[i];
            }
        }

        // [3] Output
        Console.WriteLine($"{scores.Length}명의 점수중 80점 이상의 총점: {sum}");
    }
}