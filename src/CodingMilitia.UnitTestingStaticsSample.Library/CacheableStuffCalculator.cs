using System;

namespace CodingMilitia.UnitTestingStaticsSample.Library
{
    //all the logic will be implemented in a non static class, allowing mocking and all the usual things
    public class CacheableStuffCalculator
    {
        private readonly ICache<int,string> _cache;
        
        public CacheableStuffCalculator(ICache<int,string> cache)
        {
            _cache = cache;
        }

        public string GetStringWithNLength(int n)
        {
            return _cache.GetOrAdd(n, nAgain => new string('n', nAgain));
        }
    }
}