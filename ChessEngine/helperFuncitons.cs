namespace ChessEngine
{
    public static class HelperFunctions
    {
        public static byte RowAndColumnToByte(byte row, byte column)
        {
            return (byte)(row * 8 + column);
        }

        public static ulong SetBit(ulong bitboard, int position)
        {
            if (position < 0 || position > 63)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position must be between 0 and 63.");
            }

            return bitboard | (1UL << position);
        }
        public static byte GetByte(int byteIndex, ulong bytes)
        {
            return (bytes >> byteIndex) % 2 == 1 ? (byte)1 : (byte)0;
        }
    }
}