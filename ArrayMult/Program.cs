using System;
using System.Numerics;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 6)
            {
                float[,] matrix1 = new float[2, 2];
                matrix1[0, 0] = float.Parse(args[0]);
                matrix1[0, 1] = float.Parse(args[1]);
                matrix1[1, 0] = float.Parse(args[2]);
                matrix1[1, 1] = float.Parse(args[3]);

                float[,] matrix2 = new float[1, 2];
                matrix2[0, 0] = float.Parse(args[4]);
                matrix2[0, 1] = float.Parse(args[5]);

                float[,] result = new float[2, 1];

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    result[i, 0] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        result[i, 0] += matrix1[i, k] * matrix2[0, k];
                    }
                    Console.WriteLine(result[i, 0]);
                }

            }
            else
            {
                Console.WriteLine("Not enough arguments!");
            }
        }
    }
}
