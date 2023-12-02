using Encapsulation;

namespace Abstraction;

public class ChildState : State
{
    void Test()
    {
        base.PrintProtectedInternal();
        // base.PrintProtectedPrivate(); - Ошибка
    }
    
}