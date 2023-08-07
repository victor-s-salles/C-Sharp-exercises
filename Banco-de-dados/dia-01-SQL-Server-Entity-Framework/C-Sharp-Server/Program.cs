using System.Globalization;
using Models;

public class Program
{
    public static void Main(string[] args)
    {
        var context = new StudentContext();

        context.Database.EnsureCreated();
        Console.WriteLine("Insira o nome");
        var name = Console.ReadLine() ?? "";

        Console.WriteLine("Insira a data de nascimento (dd/mm/yyyy)");
        var birthday = Console.ReadLine() ?? "";

        Console.WriteLine("Insira o endereço");
        var address = Console.ReadLine() ?? "";

        var studentToInsert = new Student
        {
            Name = name,
            Birthday = DateTime.ParseExact(birthday, "dd/MM/yyyy", CultureInfo.InvariantCulture),
            Address = address
        };
        context.Students.Add(studentToInsert);
        context.SaveChanges();
        Console.WriteLine("Pessoa estudante salva com sucesso");

        Console.WriteLine("Pessoas cadastradas:");
        var students = context.Students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Birthday} - {student.Address} ");
        }
    }
}