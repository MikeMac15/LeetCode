namespace LeetCode.HashMap;

public static class RansomNote {
public static bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> magDic = new Dictionary<char,int>();
        foreach(char c in magazine){
            magDic[c] = magDic.ContainsKey(c) ? magDic[c] + 1 : 1;
        }

        foreach(char d in ransomNote){
            if (magDic.ContainsKey(d)){
                magDic[d]--;
                if (magDic[d] < 0) return false;
            } else { return false;}
        }

        return true;
    }
}