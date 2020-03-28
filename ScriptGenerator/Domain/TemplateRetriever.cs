using System.IO;
using ScriptGeneration.Dto;
using ScriptGeneration.Extensibility;

namespace ScriptGeneration.Domain
{
    public class TemplateRetriever : ITemplateRetriever
    {
        private const string ReadingLong = "ReadingLong.txt";
        private const string ReadingShort = "ReadingShort.txt";
        private const string YoutubeLong = "YoutubeLong.txt";
        private const string YoutubeShort = "YoutubeShort.txt";

        public TemplateDto ReadingTemplates()
        {
            var templates = new string[]
            {
                ReadingLong,
                ReadingShort,
                YoutubeLong,
                YoutubeShort
            };

            var templateDto = new TemplateDto();

            var properties = templateDto.GetType().GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                properties[i].SetValue(templateDto, ReadingTemplate(templates[i]));
            }

            return templateDto;
        }

        private string ReadingTemplate(string fileName)
        {
            string templateString = string.Empty;

            string filePath = $".\\Resource\\{fileName}";
            string fullPath = Path.GetFullPath(filePath);

            using (var streamReader = new StreamReader(File.OpenRead(fullPath)))
            {
                templateString = streamReader.ReadToEnd();
            }
            return templateString;
        }
    }
}