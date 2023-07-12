/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x)
    {
        string s = x.ToString();
        string res = "";
        bool begin = true;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '-')
            {
                res = $"-{res}";
            }
            else if (!begin)
            {
                res = $"{res}{s[i]}";
            }
            else if (s[i] != '0')
            {
                begin = false;
                res = $"{res}{s[i]}";
            }
        }
        if (res=="")
        {
            return 0;
        }
        try
        {
            int test = int.Parse(res);
            return test;
        }
        catch (Exception)
        {

        }
        return 0;
    }
}
// @lc code=end

