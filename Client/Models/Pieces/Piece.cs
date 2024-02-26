using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    internal class Piece
    {
        public bool Mooved { get; set; }

        private int numberPos;

        public int NumberPos
        {
            get { return numberPos; }
            set { numberPos = value; }
        }

        private int letterPos;

        public int LetterPos
        {
            get { return letterPos; }
            set { letterPos = value; }
        }

        // true for white false for black
        private bool color;

        public bool Color
        {
            get { return color; }
            set { color = value; }
        }

        public Piece(bool color, string type, int number)
        {
            Mooved = false;
            Color = color;
            if (color && type != "pawn")
            {
                NumberPos = 1;
            }
            else if (color && type == "pawn")
            {
                NumberPos = 2;
            }
            else if (!color && type != "pawn")
            {
                NumberPos = 8;
            }
            else if (!color && type == "pawn")
            {
                NumberPos = 7;
            }

            switch (type)
            {
                case "king":
                    LetterPos = 5; break;
                case "queen":
                    LetterPos = 4; break;
                case "bishop":
                    if (number == 1)
                    {
                        LetterPos = 3;
                    }
                    else
                    {
                        LetterPos = 6;
                    }
                    break;
                case "knight":
                    if (number == 1)
                    {
                        LetterPos = 2;
                    }
                    else
                    {
                        LetterPos = 7;
                    }
                    break;
                case "rook":
                    if (number == 1)
                    {
                        LetterPos = 1;
                    }
                    else
                    {
                        LetterPos = 8;
                    }
                    break;
                case "pawn":
                    LetterPos = number; break;
            }
        }

        public void moveTo(int x , int y) { }
    }
}
