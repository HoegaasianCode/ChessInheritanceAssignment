using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Oblig2Modul3
{
    public class Rook: Piece
    {
        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }

        public Rook(string symbol = "LPR") : base(symbol)
        {
        }
    }
}
