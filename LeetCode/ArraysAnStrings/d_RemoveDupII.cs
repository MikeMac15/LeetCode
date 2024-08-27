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

// 08/26
    // 2 HashSets instead of dictionary
        //     HashSet<int> unique = new HashSet<int>();
        //     HashSet<int> used = new HashSet<int>();
        //     int k = 0;
        //     for (int i = 0; i < nums.Length; ++i){
        //         if (!used.Contains(nums[i])){
        //             if (unique.Contains(nums[i])){
        //                 used.Add(nums[i]);
        //                 nums[k] = nums[i];
        //             } else {
        //                 unique.Add(nums[i]);
        //                 nums[k] = nums[i];
        //             }
        //             k++;
        //         }
        //     }
        //     return k;

// python3
    // def removeDuplicates(self, nums: List[int]) -> int:
    //         dic = {}
    //         x = 0
    //         for num in nums:
    //             dic[num] = dic.get(num,0) + 1
                
    //             if dic[num] <= 2:
    //                 nums[x] = num
    //                 x += 1
    //         return x

// TypeScript
    // function removeDuplicates(nums: number[]): number {
    //     let dic: {[key:number]: number} = {}
    //     let x = 0

    //     for (let num of nums){
    //         if (dic.hasOwnProperty(num)){
    //             dic[num]++
    //         } else {
    //             dic[num] = 1
    //         }

    //         if (dic[num] <= 2){
    //             nums[x] = num
    //             x++
    //         }
    //     }
    //     return x
    // };