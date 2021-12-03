using System;

namespace exemplo.Models
{
    public class Calculos
    {
        //Delegate
        public delegate void DelegateCalculos();

        //Evento
        public static event DelegateCalculos EventoCalculos;
        
        public static void soma (int x, int y)
        {
            if(EventoCalculos != null)
            {
                Console.WriteLine($"Soma entre {x} e {y} = {x + y}");
                EventoCalculos();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }
            
        }

        public static void subtrair (int x, int y) 
        {
            Console.WriteLine($"Subitração entre {x} e {y} = {x - y}");
        }
    }
}