using System;
using Xunit;
using Moq;

namespace CodingMilitia.UnitTestingStaticsSample.Library.Tests
{
    //Now we test the class that implements the logic, as the static class only acts as a proxy
    public class GetStringWithNLengthTest
    {
        [Fact]
        public void GivenLength1ReturnsStringWithLength1()
        {
            //prepare
            var cacheMock = new Mock<ICache<int, string>>();

            cacheMock.Setup(cache => cache.GetOrAdd(It.IsAny<int>(), It.IsAny<Func<int, string>>()))
                     .Returns((int key, Func<int, string> valueProvider) => valueProvider(key));

            var calculator = new CacheableStuffCalculator(cacheMock.Object);

            //execute
            var result = calculator.GetStringWithNLength(1);

            //assert
            Assert.Equal(1, result.Length);
        }
    }
}