using NativeSingleton.Core;
using NativeSingleton.Steps;
using OpenQA.Selenium;

namespace NativeSingleton.Tests;

public class BaseTest
{
    protected NavigationSteps NavigationSteps => new NavigationSteps();
    protected ProjectSteps ProjectSteps => new ProjectSteps();
}