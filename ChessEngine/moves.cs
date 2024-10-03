namespace ChessEngine
{
    public class moves
    {
        public void MovePiece(ulong pieces, byte startPosition, byte endPosition)
        {
            pieces = pieces & ~(ulong)Math.Pow(2, startPosition);
            pieces = pieces | (ulong)Math.Pow(2, endPosition);
        }

        public bool LegalMove(byte pieceType, byte startPosition, byte endPosition)
        {    
            // 0 = White Pawn, 1 = White Knigth, 2 = White Bishop, 3 = White Rook, 4 = White Queen, 5 = White King
            // 6 = Black Pawn, 7 = Black Knigth, 8 = Black Bishop, 9 = Black Rook, 10 = Black Queen, 11 = Black King
            switch (pieceType) 
            {
                case 1:
                    break;
            }
        return false;


        }
    }
}