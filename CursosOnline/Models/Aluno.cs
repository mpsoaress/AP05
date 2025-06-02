using System;

namespace CursosOnline.Models;

public class Aluno
{
    public string Nome { get; set; }
        public List<Matricula> Matriculas { get; private set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Matriculas = new List<Matricula>();
        }

        public void Matricular(Curso curso)
        {
            Matricula matricula = new Matricula(this, curso);
            Matriculas.Add(matricula);
        }

        public override string ToString()
        {
            return Nome;
        }
}
