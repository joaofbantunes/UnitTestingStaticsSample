using System;

namespace CodingMilitia.UnitTestingStaticsSample.Library
{
    public interface ICache<TKey, TValue>
    {
         TValue GetOrAdd(TKey key, Func<TKey,TValue> addProvider);
    }
}