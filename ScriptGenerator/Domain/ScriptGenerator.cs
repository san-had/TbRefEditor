using ScriptGeneration.Dto;
using ScriptGeneration.Extensibility;

namespace ScriptGeneration.Domain
{
    public class ScriptGenerator : IScriptGenerator
    {
        private readonly ITemplateRetriever templateRetriever;

        public ScriptGenerator(ITemplateRetriever templateRetriever)
        {
            this.templateRetriever = templateRetriever;
        }

        public ScriptDto ScriptGeneration(InputDto inputDto)
        {
            var templateDto = templateRetriever.ReadingTemplates();

            var scriptDto = new ScriptDto();

            ReadingLongGeneration(inputDto, templateDto, scriptDto);

            ReadingShortGeneration(inputDto, templateDto, scriptDto);

            ListeningLongGeneration(inputDto, templateDto, scriptDto);

            ListeningShortGeneration(inputDto, templateDto, scriptDto);

            return scriptDto;
        }

        public void ReadingLongGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.ReadingLong = string.Format(
                templateDto.ReadingLongTemplate,
                inputDto.PreachDate.ToString("yyyy.MM.dd"),
                inputDto.Textus,
                inputDto.FileName,
                inputDto.Title,
                inputDto.Preacher);
        }

        public void ReadingShortGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.ReadingShort = string.Format(
                templateDto.ReadingShortTemplate,
                inputDto.Title,
                inputDto.Textus,
                inputDto.FileName,
                inputDto.PreachDate.Day.ToString());
        }

        public void ListeningLongGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.ListeningLong = string.Format(
                templateDto.ListeningLongTemplate,
                inputDto.PreachDate.ToString("yyyy.MM.dd"),
                inputDto.Textus,
                inputDto.FileName,
                inputDto.Title,
                inputDto.Preacher);
        }

        public void ListeningShortGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.ListeningShort = string.Format(
                templateDto.ListeningShortTemplate,
                inputDto.Title,
                inputDto.Textus,
                inputDto.FileName,
                inputDto.PreachDate.Day.ToString());
        }
    }
}