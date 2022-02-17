// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Console.WriteLine("Conceptos de POO");
Console.WriteLine("================");
try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2022, 2, 7));
    Console.WriteLine(new Date(2022, 11, 3));

}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
