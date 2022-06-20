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

                if(max.length()>=(temp.length()*2))
                {
                    continue;
                }

                if(max.length()<3 && j==i-1 && temp[0]==temp[1])
                {
                    max=temp;
                }
                
                if(i+1+temp.length()<=s.length())
                {
                    string sub2 = s.substr(i+1,temp.length());
                    if(sub2.find(temp)!= std::string::npos)
                    {
                        string test = s.substr(i-(temp.length()-1), temp.length()*2);
                        max = GetBiggerStr(max, test);
                    }
                }

                if(i+temp.length()<=s.length())
                {
                    string sub1 = s.substr(i,temp.length());
                    if(sub1.find(temp)!= std::string::npos)
                    {
                        string test = s.substr(i-(temp.length()-1), temp.length()*2-1);
                        max = GetBiggerStr(max, test);
                    }
                }
                else
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
