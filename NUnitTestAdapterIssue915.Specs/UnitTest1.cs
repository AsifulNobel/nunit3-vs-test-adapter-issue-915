using NUnit.Framework;
using NUnitTestAdapterIssue915v2;

namespace NUnitTestAdapterIssue915.Specs
{
  public class Tests
  {
    private Adder _sut;

    [SetUp]
    public void Setup()
    {
      _sut = new Adder();
    }

    [Test]
    public void Test1()
    {
      Assert.AreEqual(5, _sut.Add3(2));
    }

    [Test]
    public void Test2()
    {
      Assert.AreEqual(7, _sut.Add5(2));
    }

    [TestCase(9)]
    [TestCase(1)]
    public void Test3(int testInput)
    {
      Assert.AreEqual(testInput + 7, _sut.Add7(testInput));
    }
  }
}