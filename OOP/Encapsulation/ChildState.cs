namespace Encapsulation;

public class ChildState : State
{
    void Print()
    {
        protectedVar = "protected";
        PrintPublic();
        PrintProtectedInternal();
        PrintProtectedPrivate();
    }
}