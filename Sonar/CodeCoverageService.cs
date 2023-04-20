namespace Sonar
{
    public class CodeCoverageService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int PartiallyTestedCode(int x)
        {
            if (x > 0)
            {
                return x;
            }

            return x * -1;
        }
    }
}