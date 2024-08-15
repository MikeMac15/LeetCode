namespace LeetCode.TwoPointers;
    public static class MaxA
    {
        public static int MaxArea(int[] height) {
            int l = 0;
            int r = height.Length - 1;
            int area = 0;

            while (l < r){
                int tempArea = Math.Min(height[l], height[r]) * (r - l);
                if (tempArea > area) area = tempArea;

                if (height[l] < height[r]){
                    l += 1;
                }
                else{
                    r -= 1;
                }
                    
            }
            return area;
        }
    }




// TypeScript
    // function maxArea(height: number[]): number {
    //     let l = 0
    //     let r = height.length - 1
    //     let area = 0

    //     while (l < r){
    //         let tempArea = Math.min(height[l], height[r]) * (r-l)
    //         if (tempArea > area) area = tempArea;

    //         if (height[l] < height[r]){
    //             l++
    //         } else {
    //             r--
    //         }
    //     }
    //     return area
    // };
// Python3
    // def twoSum(self, numbers: List[int], target: int) -> List[int]:
    //     l, r = 0, len(numbers) - 1

    //     while l<r:
    //         sum_val = numbers[l] + numbers[r]

    //         if sum_val > target:
    //             r -= 1
    //         elif sum_val < target:
    //             l += 1
    //         else:
    //             return [l + 1, r + 1]