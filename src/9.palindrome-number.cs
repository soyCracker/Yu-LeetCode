/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int res = 0;
        int temp = x;
        while (true)
        {
            res = res * 10 + temp % 10;
            temp = temp/10;
            if(temp<=0)
            {
                break;
            }
        }

        if (res == x)
        {
            return true;
        }
        return false;
    }
}
// @lc code=end

