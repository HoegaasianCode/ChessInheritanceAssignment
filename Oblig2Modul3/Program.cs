using System;
using System.Net.Mime;
using System.Text;

namespace Oblig2Modul3
{
    class Program
    {
        /// <summary>
        /// This assignment starts as a "simple" chess game, where the pieces are condensed into a type called "Piece". 
        /// However, the game's pieces largely have unique behavior, so instead of doing conditional checks from the pieces'
        /// string values, I give each piece it's own type, including their respective behaviors. These pieces inherit their common basic 
        /// functionality from Piece, eliminating the need for if-statements in the Piece class. This might help on performance!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var board = new Board();
            var bishop = new Bishop();
            var rook = new Rook();
            board.Set("e4", bishop);
            board.Set("f7", rook);
            while (true)
            {
                board.Show();
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                var positionFrom = Ask("Hvilken rute vil du flytte fra?");
                var positionTo = Ask("Hvilken rute vil du flytte til?");
                board.Move(positionFrom, positionTo);
            }
        } 

        private static string Ask(string question)
        {
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }
    }
}