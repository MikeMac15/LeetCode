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

//TypeScript
    // function majorityElement(nums: number[]): number {
    //     let dic: {[key:number]: number} = {}
    //     let result: number = -1
    //     for (let num of nums){
    //         if (dic.hasOwnProperty(num)){
    //             dic[num]++
    //         } else {
    //             dic[num] = 1
    //         }
    //         if (dic[num] > nums.length / 2 ){
    //             result = num
    //             break
    //         }
    //     }
    //     return result
    // };

//Python3
    // def majorityElement(self, nums: List[int]) -> int:
    //     # num_dict = {}
    //     # result = 0
    //     # for num in nums:
    //     #     num_dict[num] = num_dict.get(num,0) + 1
    //     # for key, val in num_dict.items():
    //     #     if val == max(num_dict.values()):
    //     #         return key
    
    //     nums_set = set(nums)

    //     for num in nums_set:
    //         if nums.count(num) > len(nums) / 2:
    //             return num