using System;
using System.Collections.Generic;

string inputString = "1, 2, 3, 4, 4, 5";
List<string> numbers = inputString.Split(',').ToList();
List<string> uniqueNumbers = new List<string>();

foreach (string number in numbers)
{
    if (!uniqueNumbers.Contains(number))
    {
        uniqueNumbers.Add(number);
    }
}

string result = string.Join(", ", uniqueNumbers);
Console.WriteLine(result);
