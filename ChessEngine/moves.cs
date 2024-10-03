namespace ChessEngine
{
    public class moves
    {
        public ulong MovePiece(ulong pieces, byte startPosition, byte endPosition)
        {
            Debugging.PrintPieces(pieces);
            pieces = pieces & ~(ulong)Math.Pow(2, startPosition);
            pieces = pieces | (ulong)Math.Pow(2, endPosition);
            return pieces;
        }
    }
}