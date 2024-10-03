namespace ChessEngine {
    public class Evaluation {
        public float Evaluate(ChessBoard board, bool whiteToMove) {
            float evaluation = 0;

            float pawnValue = 100;
            float rookValue = 500;
            float knightsValue = 300;
            float bishopsValue = 300;
            float queenValue = 900;

            float moveFirstValue = 200;

            bool whiteKingAlive = false;
            bool blackKingAlive = false;

            if (whiteToMove == true) {
                evaluation+=moveFirstValue;
            }
            else {
                evaluation-=moveFirstValue;
            }

            
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

                if (HelperFunctions.GetByte(i, board.BlackPawns) == 1) {
                    evaluation -= pawnValue;
                }
                if (HelperFunctions.GetByte(i, board.BlackKing) == 1) {
                    blackKingAlive = true;
                }
                if (HelperFunctions.GetByte(i, board.BlackKnights) == 1) {
                    evaluation -= knightsValue;
                }
                if (HelperFunctions.GetByte(i, board.BlackBishops) == 1) {
                    evaluation -= bishopsValue;
                }
                if (HelperFunctions.GetByte(i, board.BlackRooks) == 1) {
                    evaluation -=  rookValue;
                }
                if (HelperFunctions.GetByte(i, board.BlackQueens) == 1) {
                    evaluation -= queenValue;
                }
            }
            
            if (!whiteKingAlive)  {
                evaluation += float.NegativeInfinity;
            }
            if (!blackKingAlive) {
                evaluation+=float.PositiveInfinity;
            }
        
            return evaluation;
        }
    }
}