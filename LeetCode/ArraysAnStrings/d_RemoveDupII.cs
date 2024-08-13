 public class RemoveDupII
    {
 public int RemoveDuplicates(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int k = 0;
        foreach ( int num in nums ){
            if (!dic.ContainsKey(num)){
                dic.Add(num,1);
            } else {
                dic[num]++;
            }
            if (dic[num] <= 2){
                nums[k] = num;
                k++;
            }
        }
        return k;
    }
    }