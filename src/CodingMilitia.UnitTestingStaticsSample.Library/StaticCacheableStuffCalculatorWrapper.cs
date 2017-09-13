namespace CodingMilitia.UnitTestingStaticsSample.Library
{
    public static class StaticCacheableStuffCalculatorWrapper
    {
        private static readonly CacheableStuffCalculator CalculatorInstance;

        static StaticCacheableStuffCalculatorWrapper()
        {
            //instantiates instance that'll provide the logic
            CalculatorInstance = new CacheableStuffCalculator(new SampleCache<int,string>());
        }

        public static string GetStringWithNLength(this int n)
        {
            //acts as a proxy
            return CalculatorInstance.GetStringWithNLength(n);
        }
    }
}