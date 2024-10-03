namespace ChessEngine
{
    public class moves
    {
        public void MovePiece(ulong pieces, byte startPosition, byte endPosition)
        {
            Debugging.PrintPieces(pieces);
            pieces = pieces & ~(ulong)Math.Pow(2, startPosition);
            pieces = pieces | (ulong)Math.Pow(2, endPosition);
        }
    }
}