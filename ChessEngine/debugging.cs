namespace ChessEngine
{

    public class Debugging
    {

        // Simple function to print all pieces of a certain type
        public static void PrintPieces(ulong pieces)
        {
            for (int i = 0; i < 64; i += 8)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(HelperFunctions.GetByte(i + j, pieces));
                }
                Console.WriteLine();
            }
        }
    }
}