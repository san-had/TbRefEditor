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

            YoutubeLongGeneration(inputDto, templateDto, scriptDto);

            YoutubeShortGeneration(inputDto, templateDto, scriptDto);

            return scriptDto;
        }

        public void ReadingLongGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.ReadingLong = string.Format(
                templateDto.ReadingLongTemplate,
                inputDto.PreachDate.ToString("yyyy.MM.dd"),
                inputDto.Lecture,
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
                inputDto.Lecture,
                inputDto.Textus,
                inputDto.FileName,
                inputDto.PreachDate.Day.ToString());
        }

        public void YoutubeLongGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.YoutubeLong = string.Format(
                templateDto.YoutubeLongTemplate,
                inputDto.PreachDate.ToString("yyyy.MM.dd"),
                inputDto.Lecture,
                inputDto.Textus,
                inputDto.Youtube,
                inputDto.Title,
                inputDto.Preacher);
        }

        public void YoutubeShortGeneration(InputDto inputDto, TemplateDto templateDto, ScriptDto scriptDto)
        {
            scriptDto.YoutubeShort = string.Format(
                templateDto.YoutubeShortTemplate,
                inputDto.Title,
                inputDto.Lecture,
                inputDto.Textus,
                inputDto.Youtube,
                inputDto.PreachDate.Day.ToString());
        }
    }
}