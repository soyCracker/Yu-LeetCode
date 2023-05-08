/*
 * @lc app=leetcode id=5 lang=cpp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
class Solution {
public:
    string longestPalindrome(string s) {
        int sLen = s.length();
        string max="";
        max=s[0];
        for(int i=0;i<sLen;i++)
        {
            string temp1 ="", temp2="";
            temp1 += s[i];
            bool exit1 = false, exit2 = false;
            for(int j=1;j<sLen;j++)
            {              
                if(i-j>=0 && i+j<sLen && s[i-j]==s[i+j])  //i=6 j=3
                {
                    temp1.insert(0, 1, s[i-j]);
                    temp1+=s[i+j];
                    max = GetBiggerStr(max, temp1);
                }
                else
                {
                    exit1=true;
                }
                
                if(i+1-j>=0 && i+j<sLen && s[i+1-j]==s[i+j])
                {
                    temp2.insert(0, 1, s[i+1-j]);
                    temp2+=s[i+j];
                    max = GetBiggerStr(max, temp2);
                }
                else
                {
                    exit2=true;
                }

                //代表皆未找到符合的回文，跳出j迴圈
                if(exit1 && exit2)
                {
                    break;
                }
            }         
        }
        return max;
    }

    string GetBiggerStr(string a, string b)
    {
        if(a.length()>=b.length())
        {
            return a;
        }
        return b;
    }
};
// @lc code=end
