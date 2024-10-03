namespace ChessEngine {
    public class Evaluation {
        public float Evaluate(ChessBoard board) {
            float evaluation = 0;

            float pawnValue = 100;
            float rookValue = 500;
            float knightsValue = 300;
            float bishopsValue = 300;
            float queenValue = 900;

            bool whiteKingAlive = false;

            
            for (int i = 0; i < 64; i++) {
                if (HelperFunctions.GetByte(i, board.WhitePawns) == 1) {
                    evaluation += pawnValue;
                }
                if (HelperFunctions.GetByte(i, board.WhiteKing) == 1) {
                    whiteKingAlive = true;
                }
                if (HelperFunctions.GetByte(i, board.WhiteKnights) == 1) {
                    evaluation += knightsValue;
                }
                if (HelperFunctions.GetByte(i, board.WhiteBishops) == 1) {
                    evaluation += bishopsValue;
                }
                if (HelperFunctions.GetByte(i, board.WhiteRooks) == 1) {
                    evaluation +=  rookValue;
                }
                if (HelperFunctions.GetByte(i, board.WhiteQueens) == 1) {
                    evaluation += queenValue;
                }
            }
            
            if (!whiteKingAlive)  {
                evaluation += float.NegativeInfinity;
            }
        
            return evaluation;
        }
    }
}