using System;

namespace exemplo.Models
{
    public class Pessoas
    {
        private readonly string nome;
        private readonly string sobrenome;

        public Pessoas(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar () 
        {
            Console.WriteLine(nome +" "+ sobrenome);
        }
    }
}