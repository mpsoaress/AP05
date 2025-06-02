using System;

namespace CursosOnline.Models;

public class Curso
{
    public string Nome { get; set; }
        public List<Aula> Aulas { get; private set; }

        public Curso(string nome)
        {
            Nome = nome;
            Aulas = new List<Aula>();
        }

        public void AdicionarAula(Aula aula)
        {
            Aulas.Add(aula);
        }

        public void RemoverAula(Aula aula)
        {
            Aulas.Remove(aula);
        }

        public override string ToString()
        {
            return $"{Nome} ({Aulas.Count} aulas)";
        }
}
