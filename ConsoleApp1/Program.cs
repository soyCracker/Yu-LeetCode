// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string test = "ABC";
Solution solution = new();
Console.WriteLine(solution.Convert(test, 2));

public class Solution
{
    public string Convert(string s, int numRows)
    {
        string[] arr = new string[numRows];
        for (int i = 0; i < numRows; i++)
        {
            arr[i] = "";
        }

        //計算各字元位置
        int strLen = s.Length;
        int count = 0;
        int r = 0;
        bool bevel = false;
        while (count < strLen)
        {
            arr[r] = $"{arr[r]}{s[count]}";
            count++;
            if (count == strLen)
            {
                break;
            }

            if (!bevel && r < numRows)
            {
                r++;
            }

            if (r == numRows)
            {
                bevel = true;
                r -= 1;
            }

            if (bevel && r > 0)
            {
                r--;
            }

            if (bevel && r == 0)
            {
                bevel = false;
            }
        }

        //整理結果
        string res = "";
        for (int i = 0; i < numRows; i++)
        {
            res = $"{res}{arr[i]}";
        }
        return res;
    }
}

