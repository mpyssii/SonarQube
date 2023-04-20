namespace Sonar.Tests
{
    public class CodeCoverageServiceTests
    {
        private readonly CodeCoverageService _sut = new();
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 3, 6)]
        public void AddTest(int x, int y, int z)
        {
            Assert.Equal(_sut.Add(x, y), z);
        }

        [Theory]
        [InlineData(-3, 3)]
        [InlineData(-5, 5)]
        public void PartialTest(int x, int y)
        {
            Assert.Equal(_sut.PartiallyTestedCode(x), y);
        }
    }
}