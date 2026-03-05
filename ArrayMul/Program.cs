using System;
using System.Numerics;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[,] matrix1 = new float[2, 2];
            matrix1[0,0] = float.Parse(args[0]);
            matrix1[0,1] = float.Parse(args[1]);
            matrix1[1,0] = float.Parse(args[2]);
            matrix1[1,1] = float.Parse(args[3]);

            float[,] matrix2 = new float[2, 1];
            matrix2[0,0] = float.Parse(args[4]);
            matrix2[1,0] = float.Parse(args[5]);

            float[,] result = new float[2, 1];
            
            for (int i = 0; i < result.GetLength(0); i++)
            {   
                result[i,0] = 0;
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, 0] += matrix1[i, j] * matrix2[j, 0];
                }
                
                Console.WriteLine($"| {result[i, 0],7:F2} | ");
            }

        }
    }
}
