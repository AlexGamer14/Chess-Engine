namespace ChessEngine
{
    public class ChessEngine
    {
        public static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard();

            Console.WriteLine(HelperFunctions.GetByte(1, board.AllPieces));

            Debugging.PrintPieces(board.BlackPieces);
            Console.WriteLine();
            Debugging.PrintPieces(board.WhitePieces);

            Debugging.PrintPieces(board.WhitePawns);

            ChessBoard.SetBit(board.WhitePawns, 10, true);

            Debugging.PrintPieces(board.WhitePawns);
        }
    }
}