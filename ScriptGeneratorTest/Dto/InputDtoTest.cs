using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptGeneration.Dto;

namespace ScriptGeneratorTest.Dto
{
    [TestClass]
    public class InputDtoTest
    {
        [TestMethod]
        public void CheckFileName()
        {
            var inputDto = new InputDto();
            inputDto.PreachDate = new DateTime(2019, 1, 1);

            string expectedFileName = "20190101";
            string actualFileName = inputDto.FileName;
            Assert.AreEqual(expectedFileName, actualFileName);
        }
    }
}