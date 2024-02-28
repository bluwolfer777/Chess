using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Client.Models.Customs
{
    internal class Sprite
    {
        
        Image sprite;
        private string piece;

        public string Piece
        {
            get { return piece; }
            set { piece = value; }
        }
        private bool color;

        public bool Color
        {
            get { return color; }
            set { color = value; }
        }
        private int colorpalette;

        public int Colorpalette
        {
            get { return colorpalette; }
            set { colorpalette = value; }
        }



        public Sprite(string piece, bool color, int colorpalette)
        {
            Piece = piece;
            Color = color;
            Colorpalette = colorpalette;
            switch (piece)
            {
                case "rook":
                    break;
                case "knight":
                    break;
                case "king":
                    break;
                case "queen":
                    break;
                case "bishop":
                    break;
                case "pawn":
                    break;
            }
        }

        
    }
}
