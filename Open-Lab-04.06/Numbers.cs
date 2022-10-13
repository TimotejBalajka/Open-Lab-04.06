using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int count = 0;
            for (int i =0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] evens = new int[count];
            int t = 0;
            for (int x =0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 == 0)
                {
                    evens[t] = numbers[x];
                    t++;
                }
            }
            return evens;
        }
    }
}
