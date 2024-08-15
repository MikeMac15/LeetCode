namespace LeetCode.HashMap;
public static class Isomorphic {
   
public static bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> dict1 = new Dictionary<char,char>();

        if (s.Length != t.Length) return false;

        for (int i = 0; i < s.Length; i++){
            if (dict1.ContainsKey(s[i])){
                if (dict1[s[i]] != t[i]) return false;
            } else {
                if (dict1.ContainsValue(t[i])){return false;}
                dict1.Add(s[i],t[i]);
            }
        }
        return true;
    }
}