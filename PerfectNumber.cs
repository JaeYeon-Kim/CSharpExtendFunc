class PerfectNumber
{

    // 자신을 제외한 약수의 합이 자신과 같은 수 
    // 6 = 1 + 2 + 3
    // 1 ~ 10000까지의 완전수와 개수를 출력 
    static void Main(string[] args)
    {
        int sum = 0;    // 약수의 합계 
        int cnt = 0;    // 완전수의 개수
        int max = 0;    // 가장 큰 약수 
        int rem = 0;    // 나머지값 임시 보관 


        for (int i = 1; i <= 10000; i++)
        {
            sum = 0;    // 매 반복마다 0으로 초기화 
            max = i / 2; // 모든 짝수를 2로 나누면 가장 큰 약수를 구할 수 있다. 
            for (int j = 1; j <= max; j++)
            {
                rem = i % j;    // 원래의수 / 약수 
                if (rem == 0)
                {
                    sum += j;   // 약수의 합계 
                }
            }

            if (i == sum)   // 자신 == 약수의 합계 
            {
                Console.WriteLine("완전수: {0}", i);
                cnt++;      // 완전수 개수 증가처리 
            }
        }

        Console.WriteLine("완전수 개수 : {0}", cnt);
    }
}