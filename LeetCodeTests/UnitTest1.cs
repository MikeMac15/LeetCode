using LeetCode.ArraysAnStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LeetCodeTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void MergeTwoArrTest1()
    {
        var result = MergeTwoArr.Merge(new int[] {1, 2, 3, 0, 0, 0}, 3, new int[] {2, 5, 6}, 3);
        
        CollectionAssert.AreEqual(new int[] {1, 2, 2, 3, 5, 6}, result);
    }
    [TestMethod]
    public void BuySellStockTest1()
    {
        var result = BuySellStock.MaxProfit(new int[] {7, 1, 5, 3, 6, 4});
        
        Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BuySellStockTest2()
    {
        var result = BuySellStock.MaxProfit(new int[] {7, 6, 4, 3, 1});
        
        Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void RomNumTest1()
    {
        var result = RomNum.RomanToInt("III");
        
        Assert.AreEqual(3, result);
    }
    [TestMethod]
    public void RomNumTest2()
    {
        var result = RomNum.RomanToInt("LVIII");
        
        Assert.AreEqual(58, result);
    }
    [TestMethod]
    public void RomNumTest3()
    {
        var result = RomNum.RomanToInt("MCMXCIV");
        
        Assert.AreEqual(1994, result);
    }
}