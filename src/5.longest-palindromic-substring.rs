/*
 * @lc app=leetcode id=5 lang=rust
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
impl Solution {
    pub fn longest_palindrome(s: String) -> String {
        //KMP算法
        //對字串欲處理，加入間隔符號
        let mut sharp = "#".to_string();
        let mut p = [0, s.len()*2+1];
        let mut max = 0;
        let mut targetC = 0;
        for n in s.chars() {
            sharp.push(n);
            sharp += "#";
        }
        //找最大回文半徑及中心
        for j in 1..sharp.len(){
            p[j] = GetP(sharp.clone(), j);
            if p[j] > max{
                max = p[j];
                targetC = j;
            }
        }
        return targetC.to_string();
        //組出目標字串
        let mut res="".to_string();
        for left in max..0{
            if sharp.as_bytes()[targetC-left] as char != '#'{
                res.push(sharp.as_bytes()[targetC-left] as char);
            }
        }
        if (sharp.as_bytes()[targetC] as char) != '#'{
            res.push(sharp.as_bytes()[targetC] as char);
        }
        for right in 1..max+1{
            if sharp.as_bytes()[targetC+right] as char != '#'{
                res.push(sharp.as_bytes()[targetC+right] as char);
            }
        }
        return res;
    }
}

fn GetP(t: String, c: usize) -> usize {
    let mut r = 1;
    while c-r>=0 && c+r<t.len(){
        if t.as_bytes()[c+r] as char == t.as_bytes()[c-r] as char{
            r+=1;
        }
        else {
            return r;
        }
    }
    return r-1;
}
// @lc code=end

