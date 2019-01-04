using ScriptGeneration.Dto;

namespace ScriptGeneration.Extensibility
{
    public interface IScriptGenerator
    {
        ScriptDto ScriptGeneration(InputDto inputDto);
    }
}