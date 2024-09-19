using System;
using System.Collections.Generic;
using System.Collections;
using WinFormsApp1;

namespace ChessEngine {
    public class ChessEngine {
        // Defines an array which we can use to keep track of the pieces
        // 0 Empty Square   1 White Pawn    2 White Rook    3 White Horse   4 White Bishop    5 White Queen    6 White King     Black pieces are the same but just add 6 to the white counterpart
        float evaluation = 0;

        public static void Main(string[] args)
        {
            ChessRenderer.Start();

            ChessBoard board = new ChessBoard();
            board.PrintBitboards();

            GetByte(8, board.WhitePawns);
        }
        
        public static byte GetByte(int byteIndex, ulong bytes) {
            return ((long)bytes >> byteIndex) % 2 == 1? (byte)1 : (byte)0;
        }
    }
}