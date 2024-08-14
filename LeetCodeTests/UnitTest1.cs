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
    [TestMethod]
    public void LenOfLastWordTest1()
    {
        var result = LenOfLastWord.LengthOfLastWord("Hello World");
        
        Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void LenOfLastWordTest2()
    {
        var result = LenOfLastWord.LengthOfLastWord("   fly me   to   the moon  ");
        
        Assert.AreEqual(4, result);
    }
    [TestMethod]
    public void LongComPrefixTest1()
    {
        var result = LongComPrefix.LongestCommonPrefix(new string[] {"flower", "flow", "flight"});
        
        Assert.AreEqual("fl", result);
    }
    [TestMethod]
    public void LongComPrefixTest2()
    {
        var result = LongComPrefix.LongestCommonPrefix(new string[] {"flower", "flow", "flowing"});
        
        Assert.AreEqual("flow", result);
    }
    /////////////////////////////////////////////////////////// ^10^ /////////////////////////////////////////////
    [TestMethod]
    public void LongComPrefixTest3()
    {
        var result = LongComPrefix.LongestCommonPrefix(new string[] {"dog", "racecar", "car"});
        
        Assert.AreEqual("", result);
    }
    [TestMethod]
    public void IdxOfFirstTest1()
    {
        var result = IdxOfFirst.StrStr("hello", "ll");
        
        Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void IdxOfFirstTest2()
    {
        var result = IdxOfFirst.StrStr("aaaaa", "bba");
        
        Assert.AreEqual(-1, result);
    }
    // [TestMethod]

}