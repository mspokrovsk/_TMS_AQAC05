namespace NUnitProject;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class SeverityAttribute : PropertyAttribute
{
    public SeverityAttribute(SeverityLevel level) : base(level.ToString()) {}
}