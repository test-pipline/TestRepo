
using Xunit;
using MyLib;

public class UnitTest
{
    [Fact]
    public void Test_Add()
    {
        var Calculator = new Calculator();
        int result = Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
}
