namespace ChessEngine
{
    public class ChessEngine
    {
        public static moves Mover = new();
        public static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard();

            board.BlackPawns = Mover.MovePiece(board.BlackPawns, 54, 38);

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