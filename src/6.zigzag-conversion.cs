/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] Zigzag Conversion
 */

// @lc code=start
public class Solution {
    public string Convert(string s, int numRows)
    {
        //int lines = (s.Length-numRows)/(numRows-1)+1;
        //int nodes = (s.Length-numRows)%(numRows-1);
        //int bevels = (lines-1)/(numRows-1)+1;

        if (numRows == 1)
        {
            return s;
        }

        int strLen = s.Length;
        int width = GetWidth(strLen, numRows);

        //初始化table
        char[,] table = new char[numRows, width];
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < width; j++)
            {
                table[i, j] = '#';
                //Console.Write("char:" + table[i, j]);
            }
        }

        //計算各字元位置
        int count = 0;
        int r = 0;
        int w = 0;
        bool bevel = false;
        while (count < strLen)
        {
            table[r, w] = s[count];
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
                w++;
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
            for (int j = 0; j < width; j++)
            {
                //Console.Write(table[i, j]);
                if (table[i, j] != '#')
                {
                    res += table[i, j];
                }
            }
        }
        return res;
    }

    private int GetWidth(int strLen, int numRows)
    {
        if (strLen <= numRows)
        {
            return 1;
        }

        //X  X  X  X X X X X
        //X XX XX XX XXXXXX
        //XX XX XX X X X X
        //X  X  X  X

        int branch = (strLen - numRows) / (numRows - 1);
        int even = branch % 2;
        int bevels = even == 0 ? branch / 2 : branch / 2 + 1;
        int nodes = (strLen - numRows) % (numRows - 1);
        return bevels * (numRows - 1) + nodes + 1;
    }
}
// @lc code=end

