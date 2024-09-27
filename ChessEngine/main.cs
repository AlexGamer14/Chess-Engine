using System;
using System.Collections.Generic;
using System.Collections;
using WinFormsApp1;

namespace ChessEngine {
    public class ChessEngine {
        public static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard();
            
            ChessRenderer.Start();

            Console.WriteLine(GetByte(1, board.AllPieces));

            Debugging.PrintPieces(board, board.BlackPieces);
            Console.WriteLine();
            Debugging.PrintPieces(board, board.WhitePieces);
        }
        public static byte GetByte(int byteIndex, ulong bytes) {
            return ((ulong)bytes >> byteIndex) % 2 == 1? (byte)1 : (byte)0;
        }
    }
}