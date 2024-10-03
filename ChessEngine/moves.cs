namespace ChessEngine
{
    public class moves
    {
        public void MovePiece(ChessBoard board, byte startRow, byte startColumn, byte destinationRow, byte DestinationColumn)
        {
            Debugging.PrintPieces(board.BlackPawns);
            Console.WriteLine(HelperFunctions.GetByte(10, board.AllPieces));
        }
    }
}