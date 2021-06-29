using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region execute Qst 8

            PrintNumberName(3);
            PrintNumberName(4);
            PrintNumberName(6);
            PrintNumberName(10);

            #endregion

            #region execute Qst 9

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            PrintNumbers(5);

            bool check = PrintNumbersCheck(4);
            Console.WriteLine(check);

            bool check1 = PrintNumbersCheck(10);
            Console.WriteLine(check1);

            bool check2 = PrintNumbersCheck(11);
            Console.WriteLine(check2);

            bool check3 = PrintNumbersCheck(0);
            Console.WriteLine(check3);

            #endregion

            #region execute Qst 10 - Challenge

            PrintNumbersNoLoop(1);
            PrintNumbersNoLoop(9);
            PrintNumbersNoLoop(1);
            PrintNumbersNoLoop(11);

            #endregion

            #region execute Qst 11

            int x = IsPrime(3);
            Console.WriteLine(x);

            int x1 = IsPrime(2);
            Console.WriteLine(x1);

            int x2 = IsPrime(6);
            Console.WriteLine(x2);

            int x3 = IsPrime(7);
            Console.WriteLine(x3);

            #endregion

            #region execute Qst 12

            int[] numArr = new int[5] { 2, 4, 9, 13, 17 };

            CheckArrayForPrime(numArr);

            #endregion

            #region execute Qst 13

            int[] ar1 = new int[4] { 23, 54, 4, 2 };
            int[] ar2 = new int[5] { 21, 4, 34, 7, 10 };

            int BiggerOrNot = BiggerArray(ar1, ar2);
            Console.WriteLine(BiggerOrNot);

            #endregion

            #region execute Qst 14 - Challenge

            int[,] myMat = CreateRandomMatrix();

            for (int i = 0; i < myMat.GetLength(0); i++)
            {
                for (int j = 0; j < myMat.GetLength(1); j++)
                {
                    Console.Write(myMat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int h = 0; h < 10; h++)
            {
                CheckIfExist(myMat, h + 13);
            }


            #endregion

            #region execute Qst 15 - Challenge

            int[] ArrForSort = new int[6] { -5, 10, 15, 2, 5, 100 };

            SortArray(ArrForSort);

            PrintArray(ArrForSort);

            #endregion
        }

        #region HW Qst 8

        public static void PrintNumberName(int num)
            // this function take number and print the number in word
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;

                default:
                    Console.WriteLine("Number not in range");
                    break;
            }
        }
        #endregion

        #region HW Qst 9

        private static void PrintNumbers(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static bool PrintNumbersCheck(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            if (0 < num && num <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region HW Qst 10 - Challenge

        private static void PrintNumbersNoLoop(int n)
        {
            if (n <= 10)
            {
                Console.WriteLine(n);
                PrintNumbersNoLoop(n + 1);
            }
            else
            {
                Console.WriteLine();
            }
        }

        #endregion

        #region HW Qst 11

        public static int IsPrime(int num)
        {
            int m = 2;

            while(num % m != 0 && num > m)
            {
                m++;
            }
            if (num == m)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region HW Qst 12

        private static void CheckArrayForPrime(int[] Arr)
        {
            int m = 2;
            

            for (int i = 0; i < Arr.Length; i++)
            {
                while(Arr[i] % m != 0 && Arr[i] > m)
                {
                    m++;
                }
                
                if (m == Arr[i])
                {
                    Console.WriteLine($"Value number {i} is prime!");
                }
                else
                {
                    Console.WriteLine($"Value number {i} is not prime!");
                }
            }
        }

        #endregion

        #region HW Qst 13

        private static int BiggerArray(int[] Arr1, int[] Arr2)
        {
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 0; i < Arr1.Length; i++)
            {
                sum1 += Arr1[i];
            }

            for(int j = 0; j < Arr2.Length; j++)
            {
                sum2 += Arr2[j];
            }

            if(sum1 > sum2)
            {
                return 1;
            }
            else if (sum1 == sum2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region HW Qst 14 - Challenge

        private static int[,] CreateRandomMatrix()
        {
            Random random = new Random();
            int[,] rndMatrix = new int[10, 10];

            for (int i = 0; i < rndMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < rndMatrix.GetLength(1); j++)
                {
                    rndMatrix[i, j] = random.Next(1, 101);
                }
            }
            return rndMatrix;
        }

        private static void CheckIfExist(int[,] mat, int num)
        {
            int count = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i,j] == num)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{num} is missing");
            }
            else
            {
                Console.WriteLine($"{num} is exist");
            }
        }

        #endregion

        #region HW Qst 15 - Challenge

        private static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        #endregion
    }
}
