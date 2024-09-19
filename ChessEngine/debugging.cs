namespace ChessEngine
{

    public class Debugging
    {
        private static byte GetByte(int byteIndex, ulong bytes)
        {
            return ((ulong)bytes >> byteIndex) % 2 == 1 ? (byte)1 : (byte)0;
        }

        // Simple function to print all pieces of a certain type
        public static void PrintPieces(ChessBoard board, ulong pieces)
        {
            for (int i = 0; i < 64; i += 8)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(GetByte(i + j, pieces));
                }
                Console.WriteLine();
            }
        }
    }
}