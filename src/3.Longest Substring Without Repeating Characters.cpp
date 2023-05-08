#include <string>
#include <map>
using namespace std;

class Solution {
public:  
    int lengthOfLongestSubstring(string s) {
        int res = 0;
        int slen = s.size();
        map<char, int> hmap;
        for (int i = 0; i < slen; i++)
        {
            int len = 0;
            for (int j = i; j < slen; j++)
            {
                if (hmap[s[j]])
                {
                    if (len > res)
                    {
                        res = len;
                    }
                    break;
                }
                hmap[s[j]]=1;
                len++;
            }
            if (len > res)
            {
                res = len;
            }
            hmap.clear();
        }
        return res;
        /*string res = "", tem = "";
        int len = s.size();     
        for (int i = 0; i < len; i++)
        {
            for (int j = i; j < len; j++)
            {
                if (tem.find(s[j]) != string::npos)
                {
                    if (tem.size() > res.size())
                    {
                        res = tem;
                    }
                    break;
                }
                tem += s[j];
            }
            if (tem.size() > res.size())
            {
                res = tem;                
            }
            tem = "";
        }
        return res.size();*/
    }
};