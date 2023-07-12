// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Solution solution = new();
Console.WriteLine(solution.Reverse(-10));

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x<0)
        {
            return false;
        }

        int res = 0;
        int temp = x;
        while (temp>0)
        {
            res = res*10 + temp%10;
            temp/=10;
        }

        if (res==x)
        {
            return true;
        }
        return false;
    }

    public int Reverse(int x)
    {
        //bool negative = false;
        //if (x<0)
        //{
        //    negative = true;
        //}

        int res = 0;
        int temp = x;
        while (true)
        {
            res = res*10 + temp%10;
            temp/=10;
            if (temp==0)
            {
                return res;
            }
        }
    }
}

