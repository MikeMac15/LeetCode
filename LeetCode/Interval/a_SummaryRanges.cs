namespace LeetCode.Interval;
public static class SummaryRange{
public static IList<string> SummaryRanges(int[] nums) {
        List<string> result = new List<string>();
        int start;
        int count = 0;
        int i = 0;
        while ( i < nums.Length){
            start = nums[i];
            while (i < nums.Length - 1 && nums[i]+1 == nums[i+1]){
                i++;
                count++; 
            }
            if (count > 0){
                result.Add($"{start}->{start+count}");
            } else {
                result.Add($"{start}");
            }
            i++;
            count = 0;
        }
        return result;
    }
}