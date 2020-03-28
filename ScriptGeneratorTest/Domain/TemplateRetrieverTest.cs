using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using ScriptGeneration.Extensibility;

namespace ScriptGeneratorTest.Domain
{
    [TestClass]
    public class TemplateRetrieverTest : TestBase
    {
        [TestMethod]
        public void CheckProperTemplate()
        {
            var templateRetriever = Kernel.Get<ITemplateRetriever>();
            var templateDto = templateRetriever.ReadingTemplates();

            int expectedReadingLongTemplateCharNumber = 115;
            int actualReadingLongTemplateCharNumber = templateDto.ReadingLongTemplate.Length;
            Assert.AreEqual(expectedReadingLongTemplateCharNumber, actualReadingLongTemplateCharNumber);

            int expectedReadingShortTemplateCharNumber = 74;
            int actualReadingShortTemplateCharNumber = templateDto.ReadingShortTemplate.Length;
            Assert.AreEqual(expectedReadingShortTemplateCharNumber, actualReadingShortTemplateCharNumber);

            int expectedListeningLongTemplateCharNumber = 109;
            int actualListeningLongTemplateCharNumber = templateDto.YoutubeLongTemplate.Length;
            Assert.AreEqual(expectedListeningLongTemplateCharNumber, actualListeningLongTemplateCharNumber);

            int expectedListeningShortTemplateCharNumber = 68;
            int actualListeningShortTemplateCharNumber = templateDto.YoutubeShortTemplate.Length;
            Assert.AreEqual(expectedListeningShortTemplateCharNumber, actualListeningShortTemplateCharNumber);
        }
    }
}