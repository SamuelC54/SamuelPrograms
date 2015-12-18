import java.util.ArrayList;
import java.util.Arrays;

public class GuillaumeSolutionGenerator {

	private int[][] sudokuBoard;
	private ArrayList<Integer> listeDesTrous = new ArrayList<Integer>();
	
	public GuillaumeSolutionGenerator(int[][] board){
		sudokuBoard = board;
	}
	
	public int[][] generateSolution(){
		
		for(int i = 0;i<9;i++){
			for(int j=0;j<9;j++){
				if(sudokuBoard[i][j]==0){
					listeDesTrous.add(j+i*9);
				}
			}
		}
		
		bruteForceTest();
		
		//retourner le board final
		return sudokuBoard;
	}
	
	public boolean isBoardOk(int[][] board){
		int positionX;
		int positionY;
	
		for(int i = 0;i<listeDesTrous.size();i++){
			positionX = listeDesTrous.get(i)/9;
			positionY = listeDesTrous.get(i)%9;
			
			if(!isNumberOk(positionX,positionY,board)){
				//System.out.println(i + " , " + j);
				return false;
				
			}
		}
		return true;
	}
	
	public boolean isNumberOk(int x, int y,int[][] board){
		int numberSelected;
		int counter;
		int[] occurenceChiffre = new int[10];
		
		numberSelected = board[x][y];
		
		//System.out.println(numberSelected + "(" + x + "," + y + ")");
		
		if(numberSelected == 0){
			return true;
		}
		
		//vertical line check
		counter = 0;
		for(int i=0;i<9;i++){ //colonne
			if(board[x][i] == numberSelected){
				counter++;
			}
			if(counter>1){
				//System.out.println("vertical error");
				return false;
			}
		}
		
		//horizontal line check
		counter = 0;
		for(int i=0;i<9;i++){ //colonne
			if(board[i][y] == numberSelected){
				counter++;
			}
			if(counter>1){
				//System.out.println("horizontal error");
				return false;
			}
		}
		
		//block Check
		for(int k=0;k<3;k++){
			for(int j=0;j<3;j++){
				Arrays.fill(occurenceChiffre, 0);
				occurenceChiffre[board[0+j*3][0+k*3]]++;
				occurenceChiffre[board[0+j*3][1+k*3]]++;
				occurenceChiffre[board[0+j*3][2+k*3]]++;
				occurenceChiffre[board[1+j*3][0+k*3]]++;
				occurenceChiffre[board[1+j*3][1+k*3]]++;
				occurenceChiffre[board[1+j*3][2+k*3]]++;
				occurenceChiffre[board[2+j*3][0+k*3]]++;
				occurenceChiffre[board[2+j*3][1+k*3]]++;
				occurenceChiffre[board[2+j*3][2+k*3]]++;
				
				for(int i = 1;i<10;i++){
					if(occurenceChiffre[i]>1){
						return false;
					}
				}
			}
		}
		//sinon
		return true;
	}
	
	public void bruteForceTest(){
		int[] holesArray = new int[listeDesTrous.size()];
		boolean done = false;
		int positionX;
		int positionY;
		int bruteSize = (int) Math.pow(listeDesTrous.size(), listeDesTrous.size());
		bruteSize = (int) Math.pow(bruteSize, 9);
		
		Arrays.fill(holesArray, 1);
		
		while(!done){
			for(int i=0;i<listeDesTrous.size();i++){
				positionX = listeDesTrous.get(i)/9;
				positionY = listeDesTrous.get(i)%9;
				sudokuBoard[positionX][positionY] = holesArray[i];
			}
			
			addArray(holesArray,holesArray.length - 1);
			
			//System.out.println(" " + Arrays.toString(holesArray));
			if(isBoardOk(sudokuBoard)){done = true;}
		}
	}
	public void addArray(int[] tab,int pos){
		
		if(pos==0 && tab[pos]==9){
			
		}else if(tab[pos]==9){
			tab[pos] = 1;
			addArray(tab,pos-1);
		}else{
			tab[pos]++;
		}
	}
}


