namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(createFibNum.fibNum(1),Is.EqualTo(1));
        }
    }
}