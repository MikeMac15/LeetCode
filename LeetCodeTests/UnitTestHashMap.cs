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
}