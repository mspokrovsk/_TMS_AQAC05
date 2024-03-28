using NativeSingleton.Pages;
using NativeSingleton.Pages.ProjectPages;

namespace NativeSingleton.Steps;

[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseStep
{
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}