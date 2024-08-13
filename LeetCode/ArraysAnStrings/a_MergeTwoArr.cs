public class MergeTwoArr
{
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int lastIdx = m + n - 1;
        int im = m-1;
        int jn = n-1;

        while (im >= 0 && jn >= 0){
            if (nums1[im] > nums2[jn]){
                nums1[lastIdx] = nums1[im];
                im--;
            } else {
                nums1[lastIdx] = nums2[jn];
                jn--;
            }
            lastIdx--;
        }
        
        while (jn >= 0){
            nums1[lastIdx] = nums2[jn];
            jn--;
            lastIdx--;
        }

        return nums1;
    }
}

// Python3
        // i = m - 1
        // j = n - 1
        // x = m + n -1
        
        // while i >= 0 and j >= 0:
        //     if nums1[i] > nums2[j]:
        //         nums1[x] = nums1[i]
        //         i -= 1
        //     else:
        //         nums1[x] = nums2[j]
        //         j -= 1
        //     x -= 1

        // while j >= 0:
        //     nums1[x] = nums2[j]
        //     j -= 1
        //     x -= 1
// TypeScript
        // let i = m - 1
        // let j = n - 1
        // let x = m + n - 1

        // while (i >= 0 && j >= 0){
        //     if (nums1[i] > nums2[j]){
        //         nums1[x] = nums1[i]
        //         i--
        //     } else {
        //         nums1[x] = nums2[j]
        //         j--
        //     }
        //     x--
        // }

        // while (j >= 0){
        //     nums1[x] = nums2[j]
        //     j--
        //     x--
        // }