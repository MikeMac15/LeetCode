namespace LeetCode.TwoPointers;
    public static class TwoSumII
    {
public static int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length-1;
        while (left < right){

            if (numbers[right] + numbers[left] > target){
                right--;
            } 
            if (numbers[right] + numbers[left] < target){
                left++;
            } 
            if (numbers[right] + numbers[left] == target){
                return new int[] {left+1,right+1}; 
            }
        }
        return new int[] {left+1,right+1};
    }
}

// TypeScript
    // function twoSum(numbers: number[], target: number): number[] {
    //     let l = 0
    //     let r = numbers.length - 1

    //     while (l < r){
    //         let dif = numbers[r] + numbers[l]
    //         if (dif > target){
    //             r--
    //         }
    //         if (dif < target){
    //             l++
    //         }
    //         if (dif == target){
    //             return [l+1,r+1]
    //         }
    //     }
    //     return [l+1,r+1]
    // };

// // Python3
//     def twoSum(self, numbers: List[int], target: int) -> List[int]:
//         l, r = 0, len(numbers) - 1

//         while l<r:
//             sum_val = numbers[l] + numbers[r]

//             if sum_val > target:
//                 r -= 1
//             elif sum_val < target:
//                 l += 1
//             else:
//                 return [l + 1, r + 1]