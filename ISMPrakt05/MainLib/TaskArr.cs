using System;

namespace MainLib
{
    public class TaskArr
    {
        public static int [] RandomArr(int count)
        {
            Random rnd = new Random();
            int[] arr = new int[count];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
            }
            return arr;
        }

        public static int SumNegative(int[] arr)
        {
            int sum = 0;
            for (int i =0; i < arr.Length; i++)
            {
                if(0 > arr[i])
                {
                     sum += arr[i];
                }
            }
            return sum;
        }

        public static double MaxNumberAmoungPairedElem(int[] arr)
        {
            double max = -1e7;
            for (int i = 0; i <arr.Length; i++)
            {
                if(arr[i]%2==0 && max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int MultiplicationOfPairedIndex(int[] arr)
        {
            int multiplication = 1;
            for (int i=0; i < arr.Length; i++)
            {
                if(i %2 ==0)
                {
                    multiplication *= arr[i];
                }
            }
            return multiplication;
        }

        public static int MaxIndex(int[] arr)
        {
            double max = -1e7;
            int maxindex = 0;
            for(int i =0; i<arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    maxindex = i;
                }
            }
            return maxindex;
        }

        public static int AbsMaxNumber(int[] arr)
        {
            int elem = 0;
            int max = 0;
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i]; 
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if(Math.Abs(max) > Math.Abs(min))
                {
                    elem = max;
                }
                if(Math.Abs(min) > Math.Abs(max))
                {
                    elem = min;   
                }
            }
            return elem;
        }

        public static int SumIndexWithPositiveElement(int[] arr)
        {
            int Sumindexwithpositiveelement = 0;
            for(int i=0; i <arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    Sumindexwithpositiveelement += i;
                }
            }
            return Sumindexwithpositiveelement;
        }

        public static int CountOfUnpairedElement(int []arr)
        {
            int countofodd = 0;
            for (int i = 0; i< arr.Length; i++)
            {
                if(Math.Abs(arr[i]) % 2 == 1)
                {
                    countofodd++;
                }
            }
            return countofodd;
        }
    }
}
