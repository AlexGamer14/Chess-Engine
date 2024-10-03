namespace ChessEngine {
    public class Evaluation {
        public float Evaluate(ChessBoard board) {
            float evaluation = 0;

            float pawnValue = 100;
            float rookValue = 500;


            
            for (int i = 0; i < 64; i++) {
                if (HelperFunctions.GetByte(i, board.WhitePawns) == 1) {
                    evaluation += pawnValue;
                }
            }
            

        
            return evaluation;
        }
    }
}