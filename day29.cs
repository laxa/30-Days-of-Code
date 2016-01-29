using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(ReadLine());
        bool flag;
        while (n-- > 0)
        {
            flag = false;
            string input = ReadLine();
            for (int i = 1; i < input.Length; i++)
            {
                if (Math.Abs(input[i] - input[i - 1]) != Math.Abs(input[input.Length - i - 1] - input[input.Length - i]))
                {
                    WriteLine("Not Funny");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                WriteLine("Funny");
        }
    }
}
