namespace LeetCode.HashMap;
public static class TwoSums{
public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict1 = new Dictionary<int,int>();
        //         dif,idx
        for(int i = 0; i<nums.Length; i++){
            int dif = target - nums[i];
            if (dict1.ContainsKey(nums[i])){
                return [dict1[nums[i]],i];
            } else {
                if (!dict1.ContainsKey(dif)){
                    dict1.Add(dif,i);
                }
            }
        }
        return [-1,-1];
    }
}