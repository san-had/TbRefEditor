using ScriptGeneration.Dto;

namespace ScriptGeneration.Extensibility
{
    public interface ITemplateRetriever
    {
        TemplateDto ReadingTemplates();
    }
}