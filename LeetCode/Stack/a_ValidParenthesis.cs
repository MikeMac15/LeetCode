namespace LeetCode.Stack;
public static class ValidParenthesis{
public static bool IsValid(string s) {
        Stack<char> stak = new Stack<char>();

        foreach(char c in s){
            if (c=='{'||c=='('||c=='['){
                stak.Push(c);
            } else {
                if (stak.Count == 0) return false;

                char d = stak.Pop();
                if((d=='{' && c!='}')||(d=='(' && c!=')')||(d=='[' && c!=']')) return false;
            }
        }
        return stak.Count == 0;
    }
}