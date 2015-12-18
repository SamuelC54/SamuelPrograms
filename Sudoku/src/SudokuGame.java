import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Random;

import javax.swing.JPanel;

public class SudokuGame extends JPanel {
	//constantes
	private final int BIGLINESIZE = 4;//pas toute les valeur marche (problème de division)
	//attributs
	private int[][] sudokuBoard = new int[9][9];
	private int[][] sudokuBoardSolution = new int[9][9];
	private boolean[][] sudokuBoardError = new boolean[9][9];
	private boolean VerificationMode = false;
	
	public SudokuGame(){
		this.setMaximumSize(new Dimension(500, 500));
		this.setMinimumSize(new Dimension(500, 500));
	}

	public void paint(Graphics g) {
		Graphics2D g2d = (Graphics2D) g;

		int panWidth = (this.getWidth());
		int panHeight = (this.getHeight());
		
		//background
		g.setColor(Color.WHITE);
		g2d.fillRect(0, 0, this.getWidth(), this.getHeight());

		//border
		g.setColor(Color.GRAY);
		for(int i = 0; i<BIGLINESIZE;i++){ //size
			g2d.drawRect(i, i, this.getWidth()-(i*2)-1, this.getHeight()-(i*2)-1);
		}

		//Vertical Big Line
		for(int j=0;j<BIGLINESIZE;j++){//size
			for(int i=1; i<3;i++){//number of line
				g2d.drawLine((panWidth-BIGLINESIZE)/3*i+j, 0, (panWidth-BIGLINESIZE)/3*i+j, this.getHeight());
			}
		}

		//Horizontal Big Line
		for(int j=0;j<BIGLINESIZE;j++){//size
			for(int i=1; i<3;i++){//number of line
				g2d.drawLine(0, (panHeight-BIGLINESIZE)/3*i+j, this.getWidth(), (panHeight-BIGLINESIZE)/3*i+j);
			}
		}

		//Vertical little Line
		for(int i=0; i<3;i++){//number of block
			for(int j=1; j<3;j++){//number of line per block
				int BigBlockSize = (panWidth-BIGLINESIZE*5)/3;
				g2d.drawLine((BigBlockSize+BIGLINESIZE)*i+BigBlockSize/3*j+BIGLINESIZE, 0,(BigBlockSize+BIGLINESIZE)*i+BigBlockSize/3*j+BIGLINESIZE, this.getHeight());
			}
		}
		
		//Horizontal little Line
		for(int i=0; i<3;i++){//number of block
			for(int j=1; j<3;j++){//number of line per block
				int BigBlockSize = (panHeight-BIGLINESIZE*5)/3;
				g2d.drawLine(0,(BigBlockSize+BIGLINESIZE)*i+BigBlockSize/3*j+BIGLINESIZE, this.getWidth(),(BigBlockSize+BIGLINESIZE)*i+BigBlockSize/3*j+BIGLINESIZE);
			}
		}
		
		//Draw Numbers
		g.setColor(Color.BLACK);
		Font f = new Font("times new roman", Font.PLAIN, 30);
		g.setFont(f);
		
		for(int i=0;i<9;i++){
			for(int j=0;j<9;j++){
				if(sudokuBoard[i][j]>0){
					g2d.drawString(Integer.toString(sudokuBoard[i][j]), 21+55*i, 38+55*j);
				}
			}
		}
		
		//Verification
		
		if(VerificationMode){
			for(int i=0;i<9;i++){
				for(int j=0;j<9;j++){
					if(sudokuBoard[i][j]==0){
						if(sudokuBoardError[i][j]){
							g.setColor(Color.RED);
							g2d.drawString(Integer.toString(sudokuBoardSolution[i][j]), 21+55*i, 38+55*j);
						}else{
							g.setColor(Color.BLUE);
							g2d.drawString(Integer.toString(sudokuBoardSolution[i][j]), 21+55*i, 38+55*j);
						}
					}
					if(sudokuBoard[i][j] != 0 && sudokuBoard[i][j]!=sudokuBoardSolution[i][j]){
						g.setColor(Color.RED);
						g2d.drawString("X", 18+55*i, 38+55*j);
					}
				}
			}
		}
	}
	
	public void generateSudoku(){
		clearSudoku();
		this.VerificationMode = false;
		backTrackGeneration(0);		
		generateRandomHoles(3);
		this.repaint();
	}
	
	public boolean backTrackGeneration(int casePosition){
		ArrayList<Integer> randomSequence = new ArrayList<>();
		int positionX;
		int positionY;
		
		randomSequence = generateRandomSequence();
		positionX = casePosition/9;
		positionY = casePosition%9;
		
			for(int i=0;i<9;i++){
				sudokuBoard[positionX][positionY] = randomSequence.get(i);
				
				if(isNumberOk(positionX,positionY,sudokuBoard)){
					if(casePosition == 80){
						return true;
					}
					if(backTrackGeneration(casePosition+1)){
						return true;
					}
					
				}else if(i == 8){
					sudokuBoard[positionX][positionY]=0;
				}
			}
			return false;
	}
	
	public void clearSudoku(){
		for(int i=0;i<9;i++){
			Arrays.fill(sudokuBoard[i], 0);
		}
	}
	
	public void generateRandomHoles(int chanceOn10){
		Random rand = new Random();
		int randomNum;
		
		for(int i=0;i<9;i++){
			for(int j=0;j<9;j++){
				randomNum = rand.nextInt(11); //0 to 10
				if(randomNum < chanceOn10){
					sudokuBoard[i][j] = 0;
				}
			}
		}
	}
	
	public ArrayList<Integer> generateRandomSequence(){
		ArrayList<Integer> a = new ArrayList<>();
		for (int i = 1; i <= 9; i++){
		    a.add(i);
		}
		Collections.shuffle(a);
		
		return a;
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
	
	public void SolutionCheck(){
		VerificationMode = true;
		
		for(int i=0;i<9;i++){
			Arrays.fill(sudokuBoardError[i], false);
		}
		
		for(int i=0;i<9;i++){ //ligne
			for(int j=0;j<9;j++){ //colonne
				if(!isNumberOk(i,j,sudokuBoardSolution) || sudokuBoardSolution[i][j] == 0){
					sudokuBoardError[i][j]= true;
				}
			}
		}
		this.repaint();
	}
	
	public void generateSolution(){
		int[][] sudokuBoard2 = new int[9][9];
		
		//create clone
		for(int i=0;i<9;i++){ //ligne
			for(int j=0;j<9;j++){ //colonne
				sudokuBoard2[i][j]= sudokuBoard[i][j];
			}
		}
		//call Bradley!
		BradleySolutionGenerator generator = new BradleySolutionGenerator(sudokuBoard2);
		
		sudokuBoardSolution = generator.generateSolution();
	}
	
}
