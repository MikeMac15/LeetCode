namespace LeetCode.HashMap;
public static class ContainsDupII{
    public static bool ContainsNearbyDuplicate(int[] nums, int k) {
        // Dictionary<int,int> dict1 = new Dictionary<int,int>();
        // for ( int i = 0; i < nums.Length; i++){
        //     if (dict1.TryGetValue(nums[i], out int idx)){
        //         if ( k >= i - idx ) return true;
        //         dict1[nums[i]] = i;
        //     } else {
        //         dict1.Add(nums[i],i);
        //     }
        // }
        // return false;

        if (nums == null || nums.Length == 0 || k <= 0)
            return false;

        HashSet<int> window = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if ( window.Contains(nums[i]) ) return true;
            window.Add(nums[i]);
            if (i >= k){
                window.Remove(nums[i-k]);
                window.Add(nums[i]);
            } 
        }
        return false;
    }
}