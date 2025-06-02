using System;

namespace CursosOnline.Models;

public class Aula
{
    public string Titulo { get; set; }
        public TimeSpan Duracao { get; set; }
        public string Professor { get; set; }

        public Aula(string titulo, TimeSpan duracao, string professor)
        {
            Titulo = titulo;
            Duracao = duracao;
            Professor = professor;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Duracao} - Prof. {Professor}";
        }
}
