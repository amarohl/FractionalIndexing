namespace FractionalIndexing.Tests;

[TestClass]
public sealed class ChallengeTests
{
    [TestMethod]
    public void GenerateDefaultFractionalIndicesThrowsOnNegative()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.GenerateDefaultFractionalIndices(-1));
    }

    [TestMethod]
    public void GenerateDefaultFractionalIndices0()
    {
        var actual = Challenge.GenerateDefaultFractionalIndices(0);
        var expected = new List<string> { };
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GenerateDefaultFractionalIndices3()
    {
        var actual = Challenge.GenerateDefaultFractionalIndices(3);
        var expected = new List<string> { "a0fffffV", "a1fffffV", "a2fffffV", };
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GenerateDefaultFractionalIndices64()
    {
        var actual = Challenge.GenerateDefaultFractionalIndices(64);
        var expected = new List<string> {
            "a0fffffV",
            "a1fffffV",
            "a2fffffV",
            "a3fffffV",
            "a4fffffV",
            "a5fffffV",
            "a6fffffV",
            "a7fffffV",
            "a8fffffV",
            "a9fffffV",
            "aAfffffV",
            "aBfffffV",
            "aCfffffV",
            "aDfffffV",
            "aEfffffV",
            "aFfffffV",
            "aGfffffV",
            "aHfffffV",
            "aIfffffV",
            "aJfffffV",
            "aKfffffV",
            "aLfffffV",
            "aMfffffV",
            "aNfffffV",
            "aOfffffV",
            "aPfffffV",
            "aQfffffV",
            "aRfffffV",
            "aSfffffV",
            "aTfffffV",
            "aUfffffV",
            "aVfffffV",
            "aWfffffV",
            "aXfffffV",
            "aYfffffV",
            "aZfffffV",
            "aafffffV",
            "abfffffV",
            "acfffffV",
            "adfffffV",
            "aefffffV",
            "affffffV",
            "agfffffV",
            "ahfffffV",
            "aifffffV",
            "ajfffffV",
            "akfffffV",
            "alfffffV",
            "amfffffV",
            "anfffffV",
            "aofffffV",
            "apfffffV",
            "aqfffffV",
            "arfffffV",
            "asfffffV",
            "atfffffV",
            "aufffffV",
            "avfffffV",
            "awfffffV",
            "axfffffV",
            "ayfffffV",
            "azfffffV",
            "b00ffffV",
            "b01ffffV",
        };
        Assert.AreEqual(expected, actual);
    }
}
