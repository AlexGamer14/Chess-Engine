using System;
using System.Collections.Generic;
using System.Collections;

namespace ChessEngine {
    public class ChessEngine {
        // Defines an array which we can use to keep track of the pieces
        // 0 Empty Square   1 White Pawn    2 White Rook    3 White Horse   4 White Bishop    5 White Queen    6 White King     Black pieces are the same but just add 6 to the white counterpart
        float evaluation = 0;

        public static byte[,] pieces = new byte[8,8] {
            { 8, 9, 10, 11, 12, 10, 9, 8 },
            { 7, 7, 7, 7, 7, 7, 7, 7 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 2, 3, 4, 5, 6, 4, 3, 2 }
        };


        public static void Main(string[] args)
        {
            Console.WriteLine(pieces[6,0]);
        }
    }
}