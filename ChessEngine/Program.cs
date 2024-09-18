using System;
using System.Collections.Generic;
using System.Collections;

namespace ChessEngine {
    public class ChessEngine {
        // Defines an array which we can use to keep track of the pieces
        // 0 Empty Square   1 White Pawn    2 White Rook    3 White Horse   4 White Bishop    5 White Queen    6 White King     Black pieces are the same but just add 6 to the white counterpart
        float evaluation = 0;

        public static UInt64 whitePawns = 0b0000000011111111000000000000000000000000000000000000000000000000;


        public static void Main(string[] args)
        {
            Console.WriteLine(whitePawns);
        }
    }
}