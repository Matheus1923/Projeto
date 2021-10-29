using System;
using System.Reflection;

namespace ProjetoTreinamentoG20.AAPPII.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}