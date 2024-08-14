namespace LeetCode.ArraysAnStrings;
public static class LongComPrefix
{
public static string LongestCommonPrefix(string[] strs) {
        char[] sb = new char[strs[0].Length];
        int sbIdx = 0;
        for (int i = 0; i < strs[0].Length; i++){
            char c = strs[0][i];
            bool exit = false;
            for (int j = 0; j < strs.Length; j++){
                if (i < strs[j].Length){
                    if (c != strs[j][i]){
                        exit = true;
                        break;
                    }
                } else {
                    exit = true;
                    break;
                }
            }
            if (exit){
                break;
            } else {
                sb[sbIdx] = c;
                sbIdx++;
            }
        }
        return new string(sb,0,sbIdx);
    }
}