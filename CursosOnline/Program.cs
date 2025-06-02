using CursosOnline.Models;

namespace CursosOnline;

class Program
{
    static void Main(string[] args)
    {
        // Criar curso e aulas
            Curso cursoCSharp = new Curso("C# Básico");
            cursoCSharp.AdicionarAula(new Aula("Introdução", TimeSpan.FromMinutes(30), "João"));
            cursoCSharp.AdicionarAula(new Aula("Tipos de Dados", TimeSpan.FromMinutes(45), "Maria"));

            // Criar aluno
            Aluno aluno1 = new Aluno("Ana Clara");

            // Matricular
            aluno1.Matricular(cursoCSharp);

            // Exibir informações
            Console.WriteLine(cursoCSharp);
            foreach (var aula in cursoCSharp.Aulas)
                Console.WriteLine("  " + aula);

            Console.WriteLine("\nMatrículas:");
            foreach (var m in aluno1.Matriculas)
                Console.WriteLine(m);
    }
}
