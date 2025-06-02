using System;

namespace CursosOnline.Models;

public class Matricula
{
    public Aluno Aluno { get; private set; }
        public Curso Curso { get; private set; }
        public DateTime DataInscricao { get; private set; }
        public double Progresso { get; set; } // em percentual: 0 a 100

        public Matricula(Aluno aluno, Curso curso)
        {
            Aluno = aluno;
            Curso = curso;
            DataInscricao = DateTime.Now;
            Progresso = 0.0;
        }

        public override string ToString()
        {
            return $"{Aluno.Nome} matriculado em \"{Curso.Nome}\" desde {DataInscricao.ToShortDateString()}, progresso: {Progresso}%";
        }
}
