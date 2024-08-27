using LeetCode.Stack;
namespace LeetCodeTests;

[TestClass]
public class UnitTestStack
{
    [TestMethod]
    public void ValidParenthesisTest1()
    {
        var result = ValidParenthesis.IsValid("()");
        
        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void ValidParenthesisTest2()
    {
        var result = ValidParenthesis.IsValid("()[]{}");
        
        Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void ValidParenthesisTest3()
    {
        var result = ValidParenthesis.IsValid("(]");
        
        Assert.AreEqual(false, result);
    }
    [TestMethod]
    public void ValidParenthesisTest4()
    {
        var result = ValidParenthesis.IsValid("([)]");
        
        Assert.AreEqual(false, result);
    }
}