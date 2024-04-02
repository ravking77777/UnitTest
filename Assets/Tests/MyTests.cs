using NUnit.Framework;

public class MyTests
{
    [Test]
    public void AdditionTest()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        int result = a + b;

        // Assert
        Assert.AreEqual(5, result);
    }
}