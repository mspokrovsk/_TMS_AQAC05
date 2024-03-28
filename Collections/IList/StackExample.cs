using Collections.Helper;

namespace Collections.IList;

public class StackExample
{
    public void Run()
    {
        // Создаем стек для строк
        Stack<string> myStack = new Stack<string>();
        
        // Добавляем элементы в стек
        myStack.Push("Apple");
        myStack.Push("Banana");
        myStack.Push("Cherry");

        // Выводим элементы стека
        Console.WriteLine("Stack elements:");
        PrintHelper.PrintCollection(myStack);

        // Получаем верхний элемент без удаления
        string topElement = myStack.Peek();
        Console.WriteLine($"Top element (Peek): {topElement}");

        // Удаляем верхний элемент
        string removedElement = myStack.Pop();
        Console.WriteLine($"Removed element (Pop): {removedElement}");

        // Выводим элементы после удаления
        Console.WriteLine("Stack elements after Pop:");
        PrintHelper.PrintCollection(myStack);
    }
}