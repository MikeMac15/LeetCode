namespace LeetCode.TwoPointers
{
    public static class ValidPal
    {
        
    public static bool IsPalindrome(string s) {
        int lp = 0;
        int rp = s.Length -1;
        // bool cont = true;
        // while ( lp < rp && cont ){
        while ( lp < rp ){
            while (lp < rp && !char.IsLetterOrDigit(s[lp])) {
                lp++;
            }
            while (lp < rp && !char.IsLetterOrDigit(s[rp])) {
                rp--;
            }
            if (char.ToLower(s[lp]) != char.ToLower(s[rp])) {
                return false;
            }
            lp++;
            rp--;

            // if (char.ToLower(s[lp]) == char.ToLower(s[rp])) {
            //     lp++;
            //     rp--;
            // } else {
            //     cont = false;
            // }
        }
        // return cont;
        return true;
}

    }
}

//python3
// def isPalindrome(self, s: str) -> bool:
//         lp = 0
//         rp = len(s)-1

//         while lp < rp:
            
//             while lp < rp and not s[lp].isalnum():
//                 lp += 1
    
//             while lp < rp and not s[rp].isalnum():
//                 rp -= 1

//             if s[lp].lower() != s[rp].lower():
//                 return False
                
//             lp += 1
//             rp -= 1
            
//         return True

//TypeScript
// function isPalindrome(s: string): boolean {
//     function isAlpha(char) {
//     return char.match(/^[a-z0-9]+$/i) !== null;
// }

//     let l = 0
//     let r = s.length -1

//     while (l<r){
//         while(l<r && !isAlpha(s[l])){
//             l++;
//         }
//         while(l<r && !isAlpha(s[r])){
//             r--;
//         }
//         if (s[l].toLowerCase() != s[r].toLowerCase()){
//             return false;
//         }

//         l++;
//         r--;
//     }
//     return true;
// };