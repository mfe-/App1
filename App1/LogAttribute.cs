using MethodBoundaryAspect.Fody.Attributes;
/// <summary>
/// MethodBoundaryAspect cannot be used in dotnet standard with default NuGet restore #47
/// https://github.com/vescon/MethodBoundaryAspect.Fody/issues/47 
/// </summary>
public sealed class LogAttribute : OnMethodBoundaryAspect
{
    public override void OnEntry(MethodExecutionArgs args)
    {
        System.Diagnostics.Debug.WriteLine("On entry");
    }

    public override void OnExit(MethodExecutionArgs args)
    {
        System.Diagnostics.Debug.WriteLine("On exit");
    }

    public override void OnException(MethodExecutionArgs args)
    {
        System.Diagnostics.Debug.WriteLine("On exception");
    }
}