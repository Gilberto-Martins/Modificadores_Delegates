using System;

namespace exemplo.Models
{
    public class Matematica
    {
        public int X { get; set;}
        public int Y { get; set;}

        public Matematica (int x, int y)
        {
            X = x;
            Y = y;

            Calculos.EventoCalculos += EventHandler;
        }

        public void Somar()
        {
            Calculos.soma(X, Y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método executado");
        }
    }
}