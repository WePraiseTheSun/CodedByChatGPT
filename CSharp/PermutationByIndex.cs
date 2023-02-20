using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Numerics;



namespace ConsoleApp1
{
    using System;

    class Program
    {
        public static int[] PermutationByIndex(int n, long index)
        {
            if (n > 20) throw new OverflowException("Tested only up to size of 20");

            int[] permutation = new int[n];
            long[] factorial = new long[n];

            // Initialize the factorial array
            factorial[0] = 1;
            for (int i = 1; i < n; i++)
            {
                factorial[i] = factorial[i - 1] * i;
            }

            // Initialize the permutation array
            for (int i = 0; i < n; i++)
            {
                permutation[i] = i;
            }

            // Generate the permutation
            for (int i = 0; i < n; i++)
            {
                long j = index / factorial[n - 1 - i];
                index = index % factorial[n - 1 - i];
                int temp = permutation[i];
                permutation[i] = permutation[i + j];
                permutation[i + j] = temp;
            }

            return permutation;
        }
        public static long GetIndexLength(int n)
        {
            long length = 1;
            for (int i = 2; i <= n; i++)
            {
                length *= i;
            }
            return length;
        }
        public static int[] PermutationByIndexBigInteger(int n, BigInteger index)
        {
            int[] permutation = new int[n];
            BigInteger[] factorial = new BigInteger[n];

            // Initialize the factorial array
            factorial[0] = 1;
            for (int i = 1; i < n; i++)
            {
                factorial[i] = factorial[i - 1] * i;
            }

            // Initialize the permutation array
            for (int i = 0; i < n; i++)
            {
                permutation[i] = i;
            }

            // Generate the permutation
            for (int i = 0; i < n; i++)
            {
                BigInteger j = index / factorial[n - 1 - i];
                index = index % factorial[n - 1 - i];
                int temp = permutation[i];
                permutation[i] = permutation[i + (int)j];
                permutation[i + (int)j] = temp;
            }

            return permutation;
        }
        public static BigInteger GetIndexLengthBigInteger(int n)
        {
            BigInteger length = 1;
            for (int i = 2; i <= n; i++)
            {
                length *= i;
            }
            return length;
        }
        static void Main(string[] args)
        {
            int size = 8;

            for (long i = 0; i < GetIndexLength(size); i++)
            {
                var arr = PermutationByIndex(size, i);
                Console.WriteLine(string.Join(", ", arr));

            }

            Console.ReadLine();
        }
    }
}
