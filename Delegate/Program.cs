using Delegate;

// -================= Single Cast Delegate
// new Example1().Run();
// new Example2().Run();

// -================= Multi Cast Delegate
// new Example3().Run();

// -================= Анонимные методы
//new Example4().Run();

// -================= Delegate как параметр
// new Example5().Run();

// -================= Живой пример
// new Example6().Run();

// -================= Invoke
// new Example7().Run();

// -================= Generic Delegates
// new Example8().Run();

// -================= Lambda
// Lambda lambda = new Lambda();
// lambda.Example0();
// lambda.Example1();
// lambda.Example2();
// lambda.Example3();
// lambda.Example4();
// lambda.Example5();
// lambda.Example6();

// -================= Action Delegate
ActionExamples actionExamples = new ActionExamples();
/*
actionExamples.SimpleAction();

actionExamples.PerformOperation(5, 3, Calc);
actionExamples.PerformOperation(5, 3, (a, b) => Console.WriteLine($"Sum: {a + b}"));
actionExamples.PerformOperation(5, 3, (a, b) => Console.WriteLine($"Multiply: {a * b}"));

actionExamples.Run();

void Calc(int x, int y)
{
    Console.WriteLine($"{x} {y}");
}
*/
// -================= Predicate Delegate
/*
PredicateExample predicateExample = new PredicateExample();
predicateExample.Run();
*/

// -================= Func Delegate
FuncExample funcExample = new FuncExample();
funcExample.Run();