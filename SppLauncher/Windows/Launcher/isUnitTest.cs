using System;
using System.Linq;

/// <summary>
/// Detect if we are running as part of a nUnit unit test.
/// This is DIRTY and should only be used if absolutely necessary 
/// as its usually a sign of bad design.
/// </summary>    
public static class UnitTestDetector
{
    static UnitTestDetector()
    {
        string testAssemblyName = "Microsoft.VisualStudio.QualityTools.UnitTestFramework";
        IsInUnitTest = AppDomain.CurrentDomain.GetAssemblies()
            .Any(a => a.FullName.StartsWith(testAssemblyName));
    }

    public static bool IsInUnitTest { get; private set; }
}