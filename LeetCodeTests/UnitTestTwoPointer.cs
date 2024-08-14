using LeetCode.TwoPointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LeetCodeTests;

[TestClass]
public class UnitTestTwoPointer
{
    [TestMethod]
    public void ValidPalTest1()
    {
        var result = ValidPal.IsPalindrome("A man, a plan, a canal: Panama");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void ValidPalTest2()
    {
        
        var result = ValidPal.IsPalindrome("race a car");
        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void ValidPalTest3()
    {
        var result = ValidPal.IsPalindrome(" mur der edr um ");
        Assert.AreEqual(true, result);
    }
}