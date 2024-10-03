
namespace ChessEngine
{
    public class ChessBoard
    {
        // Bitboards for each piece type
        public ulong WhitePawns ;
        public ulong WhiteKnights ;
        public ulong WhiteBishops; 
        public ulong WhiteRooks ;
        public ulong WhiteQueens; 
        public ulong WhiteKing ;

        public ulong BlackPawns ;
        public ulong BlackKnights ;
        public ulong BlackBishops; 
        public ulong BlackRooks ;
        public ulong BlackQueens;
        public ulong BlackKing ;

        // Bitboard for all pieces
        public ulong AllPieces ;

        // Bitboard for all white pieces
        public ulong WhitePieces ;

        // Bitboard for all black pieces
        public ulong BlackPieces ;

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
        }

        public void UpdateBitBoards()
        {
            WhitePieces = WhitePawns | WhiteKnights | WhiteBishops | WhiteRooks | WhiteQueens | WhiteKing;
            BlackPieces = BlackPawns | BlackKnights | BlackBishops | BlackRooks | BlackQueens | BlackKing;

            AllPieces = WhitePieces | BlackPieces;
        }

        public static ulong SetBit(ulong bitboard, int bitPosition, bool value)
        {
            if (bitPosition < 0 || bitPosition >= 64)
            {
                throw new ArgumentOutOfRangeException(nameof(bitPosition), "Bit position must be between 0 and 63.");
            }

            ulong mask = 1UL << bitPosition;

            if (value)
            {
                return bitboard | mask;
            }
            else
            {
                return bitboard & ~mask;
            }
        }
    }
}
