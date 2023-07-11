/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution
{
    private readonly string sCh = "#";

    public string LongestPalindrome(string s)
    {
        if (s.Length == 1)
        {
            return s;
        }

        if (s.Length == 2)
        {
            return s[0]==s[1] ? s : s[0].ToString();
        }

        string newS = GetNewStr(s);
        //Console.WriteLine(newS);

        //2個一組對應
        int maxR = 0;
        int center = 0;
        int[] p = new int[newS.Length];
        //Console.WriteLine($"newS.Length: {newS.Length}");

        // 当前遍历的中心最大扩散步数，其值等于原始字符串的最长回文子串的长度
        int maxLen = 0;
        // 原始字符串的最长回文子串的起始位置，与 maxLen 必须同时更新     
        int start = 0;

        for (int i = 0; i<newS.Length; i++)
        {
            //馬拉車算法的重點
            //輪詢i發現<maxR，代表i還在目前找到的最大回文範圍內
            if (i<maxR)
            {
                //i在回文的對稱點
                int mirror = 2*center-i;
                //由於回文對稱性質，可以斷定p[i]最小值，之後從此值繼續擴散
                p[i]=Math.Min(maxR-i, p[mirror]);
            }

            // 下一次尝试扩散的左右起点，能扩散的步数直接加到 p[i] 中
            int left = i-(1+p[i]);
            int right = i+(1+p[i]);

            // left >= 0 && right < sLen 保证不越界
            // str.charAt(left) == str.charAt(right) 表示可以扩散 1 次
            while (left>=0 && right<newS.Length && newS[left]==newS[right])
            {
                p[i]++;
                left--;
                right++;
            }

            // 根据 maxRight 的定义，它是遍历过的 i 的 i + p[i] 的最大者
            // 如果 maxRight 的值越大，进入上面 i < maxRight 的判断的可能性就越大，这样就可以重复利用之前判断过的回文信息了
            if (i+p[i]>maxR)
            {
                // maxRight 和 center 需要同时更新
                maxR = i+p[i];
                center = i;
            }

            if (p[i]>maxLen)
            {
                maxLen = p[i];

                start = i-maxLen;
            }
        }
        //foreach (var n in p)
        //{
        //    Console.Write($"{n}_");
        //}
        //Console.WriteLine("\n");

        //Console.WriteLine($"maxLen: {maxLen}");
        //Console.WriteLine($"start: {start}");

        //去掉分隔字元
        return newS.Substring(start, maxLen*2).Replace(sCh, "");
    }

    //對字串預處理，每字元加入#分隔
    private string GetNewStr(string origin)
    {
        string fixS = $"{sCh}";
        foreach (var c in origin)
        {
            fixS += c;
            fixS += sCh;
        }
        return fixS;
    }
}
// @lc code=end

