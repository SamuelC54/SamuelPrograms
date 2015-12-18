import java.util.Random;

public class BradleySolutionGenerator {

	private int[][] sudokuBoard;
	
	public BradleySolutionGenerator(int[][] board){
		sudokuBoard = board;
	}
	
	public int[][] generateSolution(){
		//exemple Random (qui marche pas lol)
		Random rand = new Random();
		
		for(int i=0;i<9;i++){
			for(int j=0;j<9;j++){
				sudokuBoard[i][j] = rand.nextInt(10); //0 to 9
			}
		}
		//---fin exemple Random
		
		//retourner le board final
		return sudokuBoard;
	}
}
