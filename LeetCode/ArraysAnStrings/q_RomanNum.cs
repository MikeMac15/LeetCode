namespace LeetCode.ArraysAnStrings
{  
    public static class RomNum
    {

    public static int RomanToInt(string s) {
        Dictionary<char,int> romDic = new Dictionary<char,int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000},
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++){
            if (i + 1 < s.Length && romDic[s[i]] < romDic[s[i+1]]){
                result -= romDic[s[i]];
            } else {
                result += romDic[s[i]];
            }
        }
        return result;
    }
    }}


//python3
    // def romanToInt(self, s: str) -> int:
    //     res = 0
       
    //     roman = {
    //         "I":1,
    //         "V":5,
    //         'X':10,
    //         'L':50,
    //         'C':100,
    //         'D':500,
    //         'M':1000}

    //     for i in range(len(s)):
    //         if i + 1 < len(s) and roman[s[i]] < roman[s[i+1]]:
    //             res -= roman[s[i]]
    //         else:
    //             res += roman[s[i]]
                
    //     return res
    
//TypeScript
    //    function romanToInt(s: string): number {
    //     const romDic = {
            
    //             "I":1,
    //             "V":5,
    //             'X':10,
    //             'L':50,
    //             'C':100,
    //             'D':500,
    //             'M':1000
    //     }

    //     let result = 0

    //     for (let i = 0; i < s.length; i++){
    //         if (i+1 < s.length && romDic[s[i]] < romDic[s[i+1]]){
    //             result -= romDic[s[i]]
    //         } else {
    //             result += romDic[s[i]]
    //         }
    //     }
    //     return result
    // };
