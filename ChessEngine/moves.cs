namespace ChessEngine
{
    public class moves
    {
        public void MovePiece(ChessBoard board, byte startRow, byte startColumn, byte destinationRow, byte DestinationColumn)
        {
            Debugging.PrintPieces(board, board.BlackPawns);
        }

        private byte RowAndColumnToByte(byte row, byte column)
        {
            return (byte)(row * 8 + column);
        }
    }
}