using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();

        [Fact]
        public void GetMyName()
        {
            var retrunValue = valuesController.Get(1);
            Assert.Equal("Narayana Nandyala", retrunValue.Value);
        }
    }
}
