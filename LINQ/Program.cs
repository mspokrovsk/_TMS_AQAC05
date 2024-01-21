// See https://aka.ms/new-console-template for more information

using LINQ;

public class Program
{
    static void Main()
    {
        // Testing Task
        /*
        TestTask testTask = new TestTask();
        testTask.Solve();
        */

        // Base Syntax
        /*
        BaseSyntax baseSyntax = new BaseSyntax();
        baseSyntax.RunQuerySyntax();
        baseSyntax.RunMethodSyntax();
        */

        // Where
        /*
        new Where().RunQuerySyntax();
        new Where().RunMethodSyntax();
        */

        // Select
        /*
        Select select = new Select();
        select.RunQuerySyntax();
        */

        // Два в одном
        // new TwoInOne().Run();
        
        // Переменные
        // new Variables().RunQuerySyntax();
        // new Variables().RunMethodSyntax();

        // Переменные
        // new DataAggregation().RunQuerySyntax();
        // new DataAggregation().RunMethodSyntax();
        
        // Сортировка
        // new OrderBy().RunQuerySyntax();
        // new OrderBy().RunMethodSyntax();

        // Группировка
        // new GroupBy().RunQuerySyntax();
        // new GroupBy().RunMethodSyntax();
        
        //Объединение, пересечение и разность коллекций:
        // разность
        // new Except().RunQuerySyntax();
        // new Except().RunMethodSyntax();

        // Пересечение
        // new Intersect().RunQuerySyntax();
        // new Intersect().RunMethodSyntax();

        // Объединение
        // new Union().RunQuerySyntax();
        // new Union().RunMethodSyntax();
        
        // Удаление дубликатов
        // new Distinct().RunQuerySyntax();
        // new Distinct().RunMethodSyntax();
        
        // Aggregation
        // new Aggregation().RunQuerySyntax();
        // new Aggregation().RunMethodSyntax();

        // Single Item
        //new SingleItem().RunQuerySyntax();
        // new SingleItem().RunMethodSyntax();

        // Методы Skip и Take
        // new SkipTake().RunMethodSyntax();

        // Методы All, 
        // new Condition().RunMethodSyntax();

        // Методы Join
        new Join().RunQuerySyntax();
        new Join().RunMethodSyntax();
    }
}