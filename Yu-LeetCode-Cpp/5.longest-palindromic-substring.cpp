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
        max+=s[0];
        for(int i=0;i<sLen;i++)
        {
            string temp ="";
            temp=s[i];
            for(int j=i-1;j>=0;j--)
            {              
                temp+=s[j];
                if(i+1+temp.length()<=s.length())
                {
                    string sub2 = s.substr(i+1,temp.length());
                    if(sub2.find(temp)!= std::string::npos)
                    {
                        string test = s.substr(i-(temp.length()-1), temp.length()*2);
                        if(test.length()>max.length())
                        {
                            max = test;
                        }
                    }
                }
                if(i+temp.length()<=s.length())
                {
                    string sub1 = s.substr(i,temp.length());
                    if(sub1.find(temp)!= std::string::npos)
                    {
                        string test = s.substr(i-(temp.length()-1), temp.length()*2-1);
                        if(test.length()>max.length())
                        {
                            max = test;
                        }
                    }
                }
                else
                {
                    break;
                }

                if()
            }         
        }
        return max;
    }
};
// @lc code=end
