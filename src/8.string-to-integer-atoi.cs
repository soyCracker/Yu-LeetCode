/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
public class Solution {
    public int MyAtoi(string s)
    {
        int warring = 214748364;
        int limit = 2147483647;
        int res = 0;
        bool negative = false;
        bool start = true;
        for (int i = 0; i < s.Length; i++)
        {
            if (start && s[i] == '+')
            {
                start = false;
                continue;
            }

            if (start && s[i] == '-')
            {
                negative = true;
                start = false;
                continue;
            }

            if (start && s[i] >= 48 && s[i] <= 57)
            {
                start = false;
                res = res * 10 + (s[i] - 48);
                continue;
            }
            else if (start && s[i] != ' ')
            {
                return res;
            }

            if (!start && (s[i] < 48 || s[i] > 57))
            {
                break;
            }
            else if (!start && s[i] >= 48 && s[i] <= 57)
            {
                if (res > warring)
                {
                    if (negative)
                    {
                        return -1 * limit - 1;
                    }
                    else
                    {
                        return limit;
                    }
                }
                else if (res == warring)
                {
                    if (negative)
                    {
                        if ((s[i] - 48) < 8)
                        {
                            res = res * 10 + (s[i] - 48);
                        }
                        else
                        {
                            return -1 * limit - 1;
                        }
                    }
                    else
                    {
                        if ((s[i] - 48) <= 7)
                        {
                            res = res * 10 + (s[i] - 48);
                        }
                        else
                        {
                            return limit;
                        }
                    }
                }
                else
                {
                    res = res * 10 + (s[i] - 48);
                }
            }
        }
        if (negative)
        {
            res *= -1;
        }
        return res;
    }
}
// @lc code=end

