using Ninject.Modules;
using ScriptGeneration.Domain;
using ScriptGeneration.Extensibility;

namespace ScriptGeneration
{
    public class ScriptGeneratorNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITemplateRetriever>().To<TemplateRetriever>();
            Bind<IScriptGenerator>().To<ScriptGenerator>();
        }
    }
}