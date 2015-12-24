package mainPackage;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;

import samPathFindingAlgo.BreadthFirstSearchSam;

public class PathCircuit extends JPanel{
	private int nbCaseX;
	private int nbCaseY;
	private int[][] circuit; // 0 = Rien, 1 = Mur, 2 = Path, 3 = CheminExplorer
	private int startPosX;
	private int startPosY;
	private int endPosX;
	private int endPosY;
	private int panelDimension;
	private int dimensionCaseX;
	private int dimensionCaseY;
	
	public PathCircuit(int x, int y, int panelDim) {
		EcouteurSouris sourisListener = new EcouteurSouris();
		
		this.nbCaseX = x;
		this.nbCaseY = y;
		this.panelDimension = panelDim;
		circuit = new int[x][y];
		this.setMaximumSize(new Dimension(panelDim+1, panelDim+1));
		this.setMinimumSize(new Dimension(panelDim+1, panelDim+1));
		this.dimensionCaseX= this.panelDimension/this.nbCaseX;
		this.dimensionCaseY= this.panelDimension/this.nbCaseY;
		this.addMouseListener(sourisListener);
		this.addMouseMotionListener(sourisListener);
		this.startPosX = 2;
		this.startPosY = 2;
		this.endPosX = this.nbCaseX-3;
		this.endPosY = this.nbCaseY-3;
		
	}

	public void paint(Graphics g) {
		Color wallColor=Color.RED;
		Color pathColor=Color.orange;
		Color pathEColor=Color.CYAN;
		Color startColor=Color.GREEN;
		Color endColor=Color.BLUE;
		
//		System.out.println(dimensionCaseX + " "+ dimensionCaseY);
		Graphics2D g2d = (Graphics2D) g;
		g.setColor(Color.WHITE);
		g2d.fillRect(0, 0, this.getWidth(), this.getHeight());
		
		//draw circuit
		for(int i=0;i<this.nbCaseX;i++)
		{
			for(int j=0;j<this.nbCaseY;j++)
			{
				if(circuit[i][j]==1)
				{
					g.setColor(wallColor);
					g2d.fillRect(i*dimensionCaseX, j*dimensionCaseY, dimensionCaseX, dimensionCaseY);
				}else if(circuit[i][j]==2)
				{
					g.setColor(pathColor);
					g2d.fillRect(i*dimensionCaseX, j*dimensionCaseY, dimensionCaseX, dimensionCaseY);
				}else if(circuit[i][j]==3)
				{
					g.setColor(pathEColor);
					g2d.fillRect(i*dimensionCaseX, j*dimensionCaseY, dimensionCaseX, dimensionCaseY);
				}
			}
		}
		//draw end and start position
		g.setColor(startColor);
		g2d.fillRect(startPosX*dimensionCaseX, startPosY*dimensionCaseY, dimensionCaseX, dimensionCaseY);
		g.setColor(endColor);
		g2d.fillRect(endPosX*dimensionCaseX, endPosY*dimensionCaseY, dimensionCaseX, dimensionCaseY);

		
		//draw grillage (doit être a la fin)
		g.setColor(Color.BLACK);
		for (int j = 0; j < this.getWidth(); j+=dimensionCaseX) {
			for (int k = 0; k < this.getHeight(); k+=dimensionCaseY) {
				g2d.drawRect(j, k, dimensionCaseX, dimensionCaseY);
			}
		}
		
		
	}

	public void clearAll(){
		for(int i = 0; i<circuit.length;i++){
			for(int j = 0; j<circuit[i].length;j++){
				circuit[i][j] = 0;
			}
		}
		this.repaint();
	}
	
	public void clearPath(){
		for(int i = 0; i<circuit.length;i++){
			for(int j = 0; j<circuit[i].length;j++){
				if(circuit[i][j] == 2 || circuit[i][j] == 3){
					circuit[i][j] = 0;
				}
			}
		}
		this.repaint();
	}

	public void drawWall(int x, int y){
		int caseX = x/dimensionCaseX;
		int caseY = y/dimensionCaseY;
		
		circuit[caseX][caseY] = 1;
		this.repaint();
	}
	
	public void erase(int x, int y){
		int caseX = x/dimensionCaseX;
		int caseY = y/dimensionCaseY;
		
		circuit[caseX][caseY] = 0;
		this.repaint();
	}
	
	public int[][] getCircuit(){
		return this.circuit;
	}
	
	public void setCircuit(int[][] newCircuit){
		this.circuit = newCircuit;
		this.repaint();
	}
	
	public int getStartPosX(){
		return this.startPosX;
	}
	
	public int getStartPosY(){
		return this.startPosY;
	}
	
	public int getEndPosX(){
		return this.endPosX;
	}
	
	public int getEndPosY(){
		return this.endPosY;
	}
	
	//class interne
	public class EcouteurSouris implements MouseListener,MouseMotionListener{
		
		public void mousePressed(MouseEvent e){
			if(SwingUtilities.isLeftMouseButton(e)){
				drawWall(e.getX(),e.getY());
			}else if(SwingUtilities.isRightMouseButton(e)){
				erase(e.getX(),e.getY());
			}
			clearPath();
			
			BreadthFirstSearchSam algo = new BreadthFirstSearchSam();
			PathCircuit.this.setCircuit(algo.findPath(PathCircuit.this,circuit,startPosX,startPosY,endPosX,endPosY));
		}
		
		public void mouseDragged(MouseEvent e)	{
			if(SwingUtilities.isLeftMouseButton(e)){
				drawWall(e.getX(),e.getY());
			}else if(SwingUtilities.isRightMouseButton(e)){
				erase(e.getX(),e.getY());
			}
			clearPath();
			
			BreadthFirstSearchSam algo = new BreadthFirstSearchSam();
			PathCircuit.this.setCircuit(algo.findPath(PathCircuit.this,circuit,startPosX,startPosY,endPosX,endPosY));
		}
		
		public void mouseReleased(MouseEvent e)	{}
		public void mouseMoved(MouseEvent e)	{}
		public void mouseClicked(MouseEvent e)	{}
		public void mouseEntered(MouseEvent e)	{}
		public void mouseExited(MouseEvent e)	{}
		
	}
	
}
