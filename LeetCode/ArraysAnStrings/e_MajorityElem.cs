public class MajorityElem
{
public int MajorityElement(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int result = -1;
        foreach (int num in nums) {
            if (!dic.ContainsKey(num)){
                dic.Add(num, 1);
            } else {
                dic[num]++;
            }
            if (dic[num] > nums.Length / 2) {
                result = num;
            }
        }
        return result;
    }
}