namespace ChessEngine
{
    public class moves
    {
        public void MovePiece(ChessBoard board, byte startPosition, byte endPosition)
        {
            Debugging.PrintPieces(board.BlackPawns);
            board.BlackPawns = (ulong)Math.Pow(2, startPosition);
            board.BlackPawns += (ulong)Math.Pow(2, endPosition);
        }
    }
}