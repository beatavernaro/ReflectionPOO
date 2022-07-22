using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void DisplayPublicProperties()
        {
            var operations = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var operation in operations)
            {
                if (operation.GetTypeInfo () == typeof(Aluno))
                {
                    var properties = operation.GetProperties();

                    foreach(var property in properties)
                    {
                        Console.WriteLine(property.Name);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void CreateInstance(string nome, string universidade, int matricula)
        {
            var operations = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var operation in operations)
            {
                if (operation.GetTypeInfo() == typeof(Aluno))
                {
                    var aluno1 = (Aluno)Activator.CreateInstance(operation);
                    aluno1.Nome = nome;
                    aluno1.Universidade = universidade;
                    aluno1.Matricula = matricula;

                    aluno1.ShowInfo();
                }
            }
        }

        static void Main(string[] args)
        {
            DisplayPublicProperties();
            CreateInstance("Anna Arendel", "Let's Code", 556897);
            
        }
    }
}