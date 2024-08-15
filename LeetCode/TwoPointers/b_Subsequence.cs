namespace LeetCode.TwoPointers;
    public class Subsequence
    {
        public static bool IsSubsequence(string s, string t) {
       int i = 0;
       int j = 0;

       while (j < t.Length){
            if (i == s.Length) return true;
            if (s[i] == t[j]) i++;
            
            j++;
       
       }

       return i == s.Length;
    }
}

// python3
    // def isSubsequence(self, s: str, t: str) -> bool:
    //     if len(s) == 0: return True

    //     l = 0
    //     r = 0

    //     while r < len(t):

    //         if s[l] == t[r]:
    //         l += 1
    //         r += 1
    //         if l == len(s):
    //             return True

        
    //     return False
    
//TypeScript
    // function isSubsequence(s: string, t: string): boolean {
    //     if (s.length === 0) return true
    //     let l = 0
    //     let r = 0

    //     while (r < t.length){
    //         if (s[l]===t[r]){
    //             l++
    //         }
    //         r++

    //         if (s.length === l){
    //             return true
    //         }
    //     }
    //     return false
    // };