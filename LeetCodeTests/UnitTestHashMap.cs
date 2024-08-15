using LeetCode.HashMap;
namespace LeetCodeTests;

[TestClass]
public class UnitTestHashMap
{
    [TestMethod]
    public void RansomNoteTest1()
    {
        var result = RansomNote.CanConstruct("a", "b");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void RansomNoteTest2()
    {
        var result = RansomNote.CanConstruct("aa", "ab");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void RansomNoteTest3()
    {
        var result = RansomNote.CanConstruct("aa", "aab");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void IsomorphicTest1()
    {
        var result = Isomorphic.IsIsomorphic("egg", "add");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void IsomorphicTest2()
    {
        var result = Isomorphic.IsIsomorphic("foo", "bar");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void IsomorphicTest3()
    {
        var result = Isomorphic.IsIsomorphic("paper", "title");

        Assert.AreEqual(true, result);
    }
    //////////////////^30^//////////////////
    ///
    [TestMethod]
    public void WordPatternTest1()
    {
        var result = WordPatt.WordPattern("abba", "dog cat cat dog");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void WordPatternTest2()
    {
        var result = WordPatt.WordPattern("abba", "dog cat cat fish");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void WordPatternTest3()
    {
        var result = WordPatt.WordPattern("aaaa", "dog cat cat dog");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void ValidAnagramTest1()
    {
        var result = ValidAnagram.IsAnagram("anagram", "nagaram");

        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void ValidAnagramTest2()
    {
        var result = ValidAnagram.IsAnagram("rat", "car");

        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void ValidAnagramTest3()
    {
        var result = ValidAnagram.IsAnagram("aacc", "ccac");

        Assert.AreEqual(false, result);
    }
    [   TestMethod]
    public void TwoSumsTest1()
    {
        var result = TwoSums.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

        CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
    }
    [TestMethod]
    public void TwoSumsTest2()
    {
        var result = TwoSums.TwoSum(new int[] { 3, 2, 4 }, 6);

        CollectionAssert.AreEqual(new int[] { 1, 2 }, result);
    }
    [TestMethod]
    public void TwoSumsTest3()
    {
        var result = TwoSums.TwoSum(new int[] { 3, 3 }, 6);

        CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
    }

}