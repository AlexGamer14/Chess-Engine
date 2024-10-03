namespace ChessEngine
{
    public class moves
    {
        public void MovePiece(ChessBoard board, byte startPosition, byte endPosition)
        {
            Debugging.PrintPieces(board.BlackPawns);
            board.BlackPawns -= (ulong)Math.Pow(2, startPosition);
            board.BlackPawns += (ulong)Math.Pow(2, endPosition);
        }

        public bool LegalMove(byte pieceType, byte startPosition, byte endPosition)
        {    
            // 0 = Pawn, 1 = Knigth, 2 = Bishop, 3 = Rook, 4 = Queen, 5 = King
            switch (pieceType)

        }
    }
}