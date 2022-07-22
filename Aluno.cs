namespace Reflection
{
    public class Aluno
    {
        public string Nome;
        public string Universidade;
        public int Matricula;

        public void ShowInfo()
        {
            Console.WriteLine($"Aluno: {Nome}\r\nUniversidade: {Universidade}\r\nMatrícula: {Matricula}");
        }
    }
}