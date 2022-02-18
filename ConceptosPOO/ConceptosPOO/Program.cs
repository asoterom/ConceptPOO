// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Console.WriteLine("Conceptos de POO");
Console.WriteLine("================");
try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2022, 2, 7));
    Console.WriteLine(new Date(2022, 11, 3));

    Employee employee1 = new SalaryEmployee()
    {
        id = 1010,
        FirstName = "Sandra",
        LastName = "morares",
        BirthDate = new Date(1990, 5, 23),
        HiringDate = new Date(2022, 1, 15),
        IsActive = true,
        Salary = 1815453.45M
    };
    Console.WriteLine(employee1);
    Employee employee2 = new CommissionEmployee()
    {
        id = 2020,
        FirstName = "Patricia",
        LastName = "Gutierrez",
        BirthDate = new Date(1995, 5, 23),
        HiringDate = new Date(2022, 2, 5),
        IsActive = true,
        Sales = 320000000M,
        CommissionPercentage = 0.03F
    };
    Console.WriteLine(employee2);

}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
