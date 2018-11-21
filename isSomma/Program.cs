using System;

namespace isSomma
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 2, 8, 15, 21 };
            Console.WriteLine(IsSomma(numeri, 36));
        }

        public static bool IsSomma(int[] numbers, int sum)
        {
            int i = 0;
            int j = numbers.Length-1;
            while (i<=j)
            {
                if (numbers[i] + numbers[j] == sum) return true;
                if (numbers[i] + numbers[j] > sum) j--;
                else i++;
            }
            return false;
        }
        //public static bool IsSomma1(int[] numbers, int sum)
        //{
        //    int i = 0;
        //    int j = 1;
        //    while (numbers[i] + numbers[j] <= sum)
        //    {
        //        if (numbers[i] + numbers[j] == sum) return true;
        //        j++;
        //        if (j >= numbers.Length)
        //        {
        //            i++;
        //            j = i + 1;
        //            if (j >= numbers.Length) return false;
        //        }
        //    }
        //    return false;
        //}

        //public static bool IsSomma2(int[] numbers, int sum)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] >= sum) return false;
        //        for (int j = i + 1; j < numbers.Length; j++)
        //        {
        //            if (numbers[i] + numbers[j] == sum) return true;
        //            if (numbers[i] + numbers[j] > sum) return false;
        //        }
        //    }
        //    return false;
        //}
    }
}
