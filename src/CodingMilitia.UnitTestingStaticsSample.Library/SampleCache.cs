using System;
using System.Collections.Generic;

namespace CodingMilitia.UnitTestingStaticsSample.Library
{
    public class SampleCache<TKey, TValue> : ICache<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _cacheStore;

        public SampleCache()
        {
            _cacheStore = new Dictionary<TKey, TValue>();
        }
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> addProvider)
        {
            if(!_cacheStore.TryGetValue(key, out var value))
            {
                value = addProvider(key);
                _cacheStore.Add(key, value);
            }
            
            return value;
        }
    }
}