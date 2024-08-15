namespace LeetCode.HashMap;
public static class ValidAnagram{
    public static bool IsAnagram(string s, string t) {
        Dictionary<char,int> sDict = new Dictionary<char,int>();

        if (s.Length != t.Length) return false;

        foreach(char c in s){
            if (sDict.ContainsKey(c)){
                sDict[c]++;
            } else {
                sDict.Add(c,1);
            }
        }

        foreach(char c in t){
            if (!sDict.ContainsKey(c)) return false;
            sDict[c]--;
            if (sDict[c] < 0) return false;
        }

        return true;
    }
}