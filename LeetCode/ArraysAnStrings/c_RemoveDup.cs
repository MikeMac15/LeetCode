public class RemoveDup
{
public int RemoveDuplicates(int[] nums) {
        int k = 1;
        for (int i = 1; i < nums.Length; i++){
            if ( nums[i] != nums[i-1] ){
                nums[k] = nums[i];
                k++;
            }
        }
        
        return k;
}
}

// python3
    // def removeDuplicates(self, nums: List[int]) -> int:
    //         x = 1
    //         for i in range(1,len(nums)):
    //             if nums[i - 1] != nums[i]:
    //                 nums[x] = nums[i]
    //                 x += 1
    //         return x

// TypeScript
    // function removeDuplicates(nums: number[]): number {
    //     let x: number = 1
    //     for (let i = 1; i < nums.length; i++){
    //         if (nums[i-1] !== nums[i]){
    //             nums[x] = nums[i]
    //             x++
    //         }
    //     }
    //     return x
    // };