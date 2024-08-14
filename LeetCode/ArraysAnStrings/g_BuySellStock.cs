namespace LeetCode.ArraysAnStrings
{  
public static class BuySellStock
{
    public static int MaxProfit(int[] prices) {
        int lowBuyDay = 0;
        int largestDif = 0;

        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < prices[lowBuyDay]) {
                lowBuyDay = i;
            }
            if (prices[i] - prices[lowBuyDay] > largestDif) {
                largestDif = prices[i] - prices[lowBuyDay];
            }
            }

        return largestDif;
        }
    
}
}

// python3
    // def maxProfit(self, prices: List[int]) -> int:

    //     minPrice = prices[0]
    //     maxDif = 0

    //     for num in prices:
    //         if minPrice > num:
    //             minPrice = num
    //         if num - minPrice > maxDif:
    //             maxDif = num - minPrice
        
    //     return maxDif

//TypeScript
//     function maxProfit(prices: number[]): number {
//     let minPrice = prices[0]
//     let maxDif = 0

//     for (let num of prices){
//         if (num < minPrice){
//             minPrice = num
//         }
//         if (num - minPrice > maxDif){
//             maxDif = num - minPrice
//         }
//     }
//     return maxDif
// };