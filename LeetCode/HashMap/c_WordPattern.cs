namespace LeetCode.HashMap;
public static class WordPatt{

public static bool WordPattern(string pattern, string s) {
       
        Dictionary<char,string> dict1 = new Dictionary<char,string>();
        HashSet<string> uniqueWords = new HashSet<string>();
        string[] strArr = s.Split(" ");

        if (pattern.Length != strArr.Length) return false;

        for (int i = 0; i < pattern.Length; i++){
           if (!dict1.ContainsKey(pattern[i]))
           {
            if (uniqueWords.Contains(strArr[i])) return false;
            dict1.Add(pattern[i],strArr[i]);
            uniqueWords.Add(strArr[i]);
           } else {
            if (dict1[pattern[i]] != strArr[i]) return false;
           }
        }
        return true;
    }
}