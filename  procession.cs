using System.ComponentModel;
using System.Data;
using System.Numerics;

namespace CodingTest
{


    class Procession
    {
        static void Main(string[] args)
        {
            Solution solve = new Solution();
            int[,] arr1 = new int[,]
     {
            { 1, 2 },
            { 2, 3 }
     };

            int[,] arr2 = new int[,]
{
            { 3, 4 },
            { 5, 6 }
};
            int[,] test = solve.solution(arr1, arr2);
            foreach (var item in test) 
            {
                Console.WriteLine(item);
            }
        }
    }


    public class Solution
    {

        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int row = arr1.GetLength(0);   
            int column = arr1.GetLength(1);  
            int[,] result = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return result;
        }
    }
}