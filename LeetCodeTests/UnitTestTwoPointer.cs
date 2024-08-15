using LeetCode.TwoPointers;
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
    [TestMethod]
    public void SubsequenceTest1()
    {
        var result = Subsequence.IsSubsequence("abc", "ahbgdc");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void SubsequenceTest2()
    {
        var result = Subsequence.IsSubsequence("axc", "ahbgdc");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void SubsequenceTest3()
    {
        var result = Subsequence.IsSubsequence("abc", "adsdahbgdc");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void TwoSumIITest1()
    {
        var result = TwoSumII.TwoSum(new int[] {2,7,11,15}, 9);

        CollectionAssert.AreEqual(new int[] {1,2}, result);
    }
    [TestMethod]
    public void TwoSumIITest2()
    {
        var result = TwoSumII.TwoSum(new int[] {2,3,4}, 6);

        CollectionAssert.AreEqual(new int[] {1,3}, result);
    }
    [TestMethod]
    public void MaxAreaTest1()
    {
        var result = MaxA.MaxArea(new int[] {1,8,6,2,5,4,8,3,7});

        Assert.AreEqual(49, result);
    }
    [TestMethod]
    public void MaxAreaTest2()
    {
        var result = MaxA.MaxArea(new int[] {1,1});

        Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void MaxAreaTest3()
    {
        var result = MaxA.MaxArea(new int[] {4,3,2,1,4});

        Assert.AreEqual(16, result);
    }
}