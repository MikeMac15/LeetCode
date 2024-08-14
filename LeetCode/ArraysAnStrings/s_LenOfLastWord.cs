namespace LeetCode.ArraysAnStrings
{
    public static class LenOfLastWord
    {
        public static int LengthOfLastWord(string s) {
            string[] words = s.Trim().Split(" ");
            return words[^1].Length;
        }
    }
}