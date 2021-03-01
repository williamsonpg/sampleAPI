using System;
using Xunit;
using sampleAPI.Controllers;

namespace sampleAPI.test
{
// 51bd7aa8f32afab78b971070f1c2f2e77680f0d0
/*
 * git status
 * git add .
 * git commit -m "nature of change"
 * git push origin master  
 * 
 */
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
