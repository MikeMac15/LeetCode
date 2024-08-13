public class RemoveElem
{
    public int RemoveElement(int[] nums, int val) {
        int x = 0;
        foreach(int num in nums){
            if (num != val){
                nums[x] = num;
                x++;
            }
        }
        return x;
    }
}


// python3
    // def removeElement(self, nums: List[int], val: int) -> int:
    //         x = 0

    //         for num in nums:
    //             if num != val:
    //                 nums[x] = num
    //                 x += 1
    //         return x

// TypeScript
    //  function removeElement(nums: number[], val: number): number {
    //     let x = 0
    //     for (let num of nums){
    //         if (num !== val){
    //             nums[x] = num
    //             x++
    //         }
    //     }
    //     return x
    // };