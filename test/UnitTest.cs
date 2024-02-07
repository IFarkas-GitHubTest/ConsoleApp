namespace Test;

public class UnitTest
{
  private const string Actual = "Test";
  private const string Expected = "Test";

  /// <summary>
  /// Fake test.
  /// TODO:
  /// Add real Unit Test.
  /// Or for a better 'Bang for the buck' add ReadyAPI E2E test tool (https://smartbear.com/product/ready-api) and test all possible scenarios.
  /// </summary>
  [Fact]
  public void Test() { Assert.Equal(Expected, Actual); }
}
