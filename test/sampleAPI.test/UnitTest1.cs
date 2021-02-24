using System;
using Xunit;
using sampleAPI.Controllers;

namespace sampleAPI.test
{
    public class UnitTest1
    {
        WeatherForecastController sapiCntrl = new WeatherForecastController(null);

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GetWeatherTest()
        {
            var rtn = sapiCntrl.Get();
            Assert.NotNull(rtn);
        }
    }
}
