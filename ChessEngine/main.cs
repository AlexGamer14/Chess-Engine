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
            Console.WriteLine();
            Debugging.PrintPieces(board.WhitePawns);
            Console.WriteLine();
            ChessBoard.SetBit(board.WhitePawns, 10, true);
            Console.WriteLine();
            Debugging.PrintPieces(board.WhitePawns);
        }
    }
}