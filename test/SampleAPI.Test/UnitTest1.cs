using SampleAPI.Controllers;
using Xunit;

namespace SampleAPI.Test
{
    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();

        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = valuesController.Get(1);
            Assert.Equal("Narayana Nandyala", returnValue.Value);
        }
    }
}
