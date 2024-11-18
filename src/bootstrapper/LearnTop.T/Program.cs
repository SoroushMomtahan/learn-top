// See https://aka.ms/new-console-template for more information

Console.WriteLine();

string Test() => "Hello";
Console.WriteLine(Match(Test));
TOut Match<TOut>(Func<TOut> onSuccess) => onSuccess();
