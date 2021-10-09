using System;


namespace Tarea1_grafica
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600, "TareaGrafica"))
            {
                game.Run(60.0);
            }
        }
    }
}
