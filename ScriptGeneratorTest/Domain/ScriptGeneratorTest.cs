using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using ScriptGeneration.Domain;
using ScriptGeneration.Dto;
using ScriptGeneration.Extensibility;

namespace ScriptGeneratorTest.Domain
{
    [TestClass]
    public class ScriptGeneratorTest
    {
        private static IKernel kernel;

        [ClassInitialize]
        public static void OneTimeSetup(TestContext testContext)
        {
            kernel = new StandardKernel();
            kernel.Bind<ITemplateRetriever>().To<TemplateRetriever>();
            kernel.Bind<IScriptGenerator>().To<ScriptGenerator>();
        }

        [TestMethod]
        public void CheckProperScriptGeneration()
        {
            var scriptGenerator = kernel.Get<IScriptGenerator>();

            var inputDto = new InputDto();
            inputDto.PreachDate = new DateTime(2019, 1, 1);
            inputDto.Textus = "Jer 29:1-14";
            inputDto.Title = "Az igazi keresztyén életedet";
            inputDto.Preacher = "Kis Gergely Márton";

            var scriptDto = scriptGenerator.ScriptGeneration(inputDto);

            int expectedReadingLongCharNumber = 166;
            int actualReadingLongCharNumber = scriptDto.ReadingLong.Length;
            Assert.AreEqual(expectedReadingLongCharNumber, actualReadingLongCharNumber);

            int expectedReadingShortCharNumber = 105;
            int actualReadingShortCharNumber = scriptDto.ReadingShort.Length;
            Assert.AreEqual(expectedReadingShortCharNumber, actualReadingShortCharNumber);

            int expectedListeningLongCharNumber = 160;
            int actualListeningLongCharNumber = scriptDto.ListeningLong.Length;
            Assert.AreEqual(expectedListeningLongCharNumber, actualListeningLongCharNumber);

            int expectedListeningShortCharNumber = 99;
            int actualListeningShortCharNumber = scriptDto.ListeningShort.Length;
            Assert.AreEqual(expectedListeningShortCharNumber, actualListeningShortCharNumber);
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            kernel.Dispose();
        }
    }
}