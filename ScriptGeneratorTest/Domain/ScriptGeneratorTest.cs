using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using ScriptGeneration.Dto;
using ScriptGeneration.Extensibility;

namespace ScriptGeneratorTest.Domain
{
    [TestClass]
    public class ScriptGeneratorTest : TestBase
    {
        [TestMethod]
        public void CheckProperScriptGeneration()
        {
            var scriptGenerator = Kernel.Get<IScriptGenerator>();

            var inputDto = new InputDto();
            inputDto.PreachDate = new DateTime(2019, 1, 1);
            inputDto.Lecture = "1Jn 3:1-12";
            inputDto.Textus = "Jer 29:1-14";
            inputDto.Title = "Az igazi keresztyén életedet";
            inputDto.Preacher = "Kis Gergely Márton";

            var scriptDto = scriptGenerator.ScriptGeneration(inputDto);

            int expectedReadingLongCharNumber = 182;
            int actualReadingLongCharNumber = scriptDto.ReadingLong.Length;
            Assert.AreEqual(expectedReadingLongCharNumber, actualReadingLongCharNumber);

            int expectedReadingShortCharNumber = 117;
            int actualReadingShortCharNumber = scriptDto.ReadingShort.Length;
            Assert.AreEqual(expectedReadingShortCharNumber, actualReadingShortCharNumber);

            int expectedListeningLongCharNumber = 168;
            int actualListeningLongCharNumber = scriptDto.YoutubeLong.Length;
            Assert.AreEqual(expectedListeningLongCharNumber, actualListeningLongCharNumber);

            int expectedListeningShortCharNumber = 103;
            int actualListeningShortCharNumber = scriptDto.YoutubeShort.Length;
            Assert.AreEqual(expectedListeningShortCharNumber, actualListeningShortCharNumber);
        }
    }
}