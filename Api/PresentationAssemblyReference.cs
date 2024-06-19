using System.Reflection;

namespace Api
{
    public static class PresentationAssemblyReference
    {
        public static readonly Assembly Assembly = typeof(PresentationAssemblyReference).Assembly;
    }
}
