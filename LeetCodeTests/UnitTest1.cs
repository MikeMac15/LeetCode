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
}