using System;
using exemplo.Models;

namespace exemplo
{
    class Program
    {

        public delegate void Operacao (int x, int y);
        static void Main(string[] args)
        {
            //Pessoas pes = new Pessoas("Fulano","De Tal");
            //pes.Apresentar();

            //const double pi = 3.14;
            //Console.WriteLine(pi);

            //Delegates
            //Operacao op = new Operacao(Calculos.soma);

            //multi Cast Delegate
            //op += Calculos.subtrair;


            // Operacao op = Calculos.soma;
            //op.Invoke(10,10);
            //op(20, 20);
            Matematica mat = new Matematica(10 , 20);
            mat.Somar();
        }
    }
}
