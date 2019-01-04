using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptGeneration.Domain;

namespace ScriptGeneratorTest.Domain
{
    [TestClass]
    public class TemplateRetrieverTest
    {
        [TestMethod]
        public void CheckProperTemplate()
        {
            var templateRetriever = new TemplateRetriever();
            var templateDto = templateRetriever.ReadingTemplates();

            int expectedReadingLongTemplateCharNumber = 106;
            int actualReadingLongTemplateCharNumber = templateDto.ReadingLongTemplate.Length;
            Assert.AreEqual(expectedReadingLongTemplateCharNumber, actualReadingLongTemplateCharNumber);

            int expectedReadingShortTemplateCharNumber = 69;
            int actualReadingShortTemplateCharNumber = templateDto.ReadingShortTemplate.Length;
            Assert.AreEqual(expectedReadingShortTemplateCharNumber, actualReadingShortTemplateCharNumber);

            int expectedListeningLongTemplateCharNumber = 100;
            int actualListeningLongTemplateCharNumber = templateDto.ListeningLongTemplate.Length;
            Assert.AreEqual(expectedListeningLongTemplateCharNumber, actualListeningLongTemplateCharNumber);

            int expectedListeningShortTemplateCharNumber = 63;
            int actualListeningShortTemplateCharNumber = templateDto.ListeningShortTemplate.Length;
            Assert.AreEqual(expectedListeningShortTemplateCharNumber, actualListeningShortTemplateCharNumber);
        }
    }
}