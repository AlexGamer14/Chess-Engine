
namespace ChessEngine {
    public class ChessBoard
    {
        // Bitboards for each piece type
        public ulong WhitePawns { get; private set; }
        public ulong WhiteKnights { get; private set; }
        public ulong WhiteBishops { get; private set; }
        public ulong WhiteRooks { get; private set; }
        public ulong WhiteQueens { get; private set; }
        public ulong WhiteKing { get; private set; }
    
        public ulong BlackPawns { get; private set; }
        public ulong BlackKnights { get; private set; }
        public ulong BlackBishops { get; private set; }
        public ulong BlackRooks { get; private set; }
        public ulong BlackQueens { get; private set; }
        public ulong BlackKing { get; private set; }
    
        // Bitboard for all pieces
        public ulong AllPieces { get; private set; }
    
        // Bitboard for all white pieces
        public ulong WhitePieces { get; private set; }
    
        // Bitboard for all black pieces
        public ulong BlackPieces { get; private set; }
    
        // Bitboard for empty squares
        public ulong EmptySquares { get; private set; }
    
        // Initialize the board with the starting position
        public ChessBoard()
        {
            // Initialize the bitboards
            WhitePawns = 0x000000000000FF00; // Rank 2
            WhiteKnights = 0x0000000000000042; // b1 and g1
            WhiteBishops = 0x0000000000000024; // c1 and f1
            WhiteRooks = 0x0000000000000081; // a1 and h1
            WhiteQueens = 0x0000000000000010; // d1
            WhiteKing = 0x0000000000000008; // e1
    
            BlackPawns = 0x00FF000000000000; // Rank 7
            BlackKnights = 0x4200000000000000; // b8 and g8
            BlackBishops = 0x2400000000000000; // c8 and f8
            BlackRooks = 0x8100000000000000; // a8 and h8
            BlackQueens = 0x1000000000000000; // d8
            BlackKing = 0x0800000000000000; // e8
    
            // Calculate the bitboards for all pieces, white pieces, black pieces, and empty squares
            AllPieces = WhitePawns | WhiteKnights | WhiteBishops | WhiteRooks | WhiteQueens | WhiteKing |
                        BlackPawns | BlackKnights | BlackBishops | BlackRooks | BlackQueens | BlackKing;
    
            WhitePieces = WhitePawns | WhiteKnights | WhiteBishops | WhiteRooks | WhiteQueens | WhiteKing;
            BlackPieces = BlackPawns | BlackKnights | BlackBishops | BlackRooks | BlackQueens | BlackKing;
    
            EmptySquares = ~AllPieces;
        }
    
        // Method to print the bitboards
        public void PrintBitboards()
        {
            Console.WriteLine("White Pawns: " + Convert.ToString((long)WhitePawns, 2).PadLeft(64, '0'));
            Console.WriteLine("White Knights: " + Convert.ToString((long)WhiteKnights, 2).PadLeft(64, '0'));
            Console.WriteLine("White Bishops: " + Convert.ToString((long)WhiteBishops, 2).PadLeft(64, '0'));
            Console.WriteLine("White Rooks: " + Convert.ToString((long)WhiteRooks, 2).PadLeft(64, '0'));
            Console.WriteLine("White Queens: " + Convert.ToString((long)WhiteQueens, 2).PadLeft(64, '0'));
            Console.WriteLine("White King: " + Convert.ToString((long)WhiteKing, 2).PadLeft(64, '0'));
    
            Console.WriteLine("Black Pawns: " + Convert.ToString((long)BlackPawns, 2).PadLeft(64, '0'));
            Console.WriteLine("Black Knights: " + Convert.ToString((long)BlackKnights, 2).PadLeft(64, '0'));
            Console.WriteLine("Black Bishops: " + Convert.ToString((long)BlackBishops, 2).PadLeft(64, '0'));
            Console.WriteLine("Black Rooks: " + Convert.ToString((long)BlackRooks, 2).PadLeft(64, '0'));
            Console.WriteLine("Black Queens: " + Convert.ToString((long)BlackQueens, 2).PadLeft(64, '0'));
            Console.WriteLine("Black King: " + Convert.ToString((long)BlackKing, 2).PadLeft(64, '0'));
    
            Console.WriteLine("All Pieces: " + Convert.ToString((long)AllPieces, 2).PadLeft(64, '0'));
            Console.WriteLine("White Pieces: " + Convert.ToString((long)WhitePieces, 2).PadLeft(64, '0'));
            Console.WriteLine("Black Pieces: " + Convert.ToString((long)BlackPieces, 2).PadLeft(64, '0'));
            Console.WriteLine("Empty Squares: " + Convert.ToString((long)EmptySquares, 2).PadLeft(64, '0'));
        }
    }
}
