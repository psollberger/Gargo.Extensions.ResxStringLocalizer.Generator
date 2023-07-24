namespace Gargo.Extensions.ResxStringLocalizer.Generator
{
  using System;
  using System.Reflection;

  internal static class ReferenceHandler
  {
    public static void Initialize()
    {
      AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainOnAssemblyResolve;
    }

    private static Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
    {
      if (args.Name.StartsWith("System.Resources.NetStandard, Version=1.1.0.0,"))
        return Assembly.Load(References.References.System_Resources_NetStandard_dll);

      if (args.Name.StartsWith("Microsoft.CodeAnalysis, Version=4.4.0.0,"))
        return Assembly.Load(References.References.Microsoft_CodeAnalysis);

      return null;
    }
  }
}
