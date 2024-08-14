namespace LeetCode.ArraysAnStrings;
public static class IdxOfFirst{
    /////////////////////////////// Sliding Window//////////////////////////////////
    public static int StrStr(string haystack, string needle) {
        for (int i = 0; i <= haystack.Length - needle.Length; i++){
            if (haystack[i..(i+needle.Length)] == needle){
                return i;
            }
        }
        return -1;
    }


//python3
    // def strStr(self, haystack: str, needle: str) -> int:
    //         for i in range(len(haystack)-len(needle)+1):
    //             if haystack[i:(i + len(needle))] == needle:
    //                 return i
    //         return -1

//TypeScript
    // function strStr(haystack: string, needle: string): number {
    //     for (let i = 0; i <= haystack.length - needle.length; i++){
    //         if (haystack.substring(i,i+needle.length) === needle){
    //             return i
    //         }
    //     }
    //     return -1
    // };




    ////////////////////First Run//////////////////////
    ///
    // public static int StrStr(string haystack, string needle) {

    //     if (needle.Length == 0) return 0;
    //     if (haystack.Length < needle.Length) return -1;

    //     for (int i = 0; i <= haystack.Length - needle.Length; i++){
    //         if (haystack[i] == needle[0]){
    //             int j;
    //             for(j = 1; j < needle.Length; j++){
    //                 if (haystack[i+j] != needle[j]){
    //                     break;
    //                 }
    //             }

    //             if (j==needle.Length){
    //                 return i;
    //             }
    //         }
    //     }
    //     return -1;
    // }
}