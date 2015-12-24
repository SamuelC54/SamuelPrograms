package samPathFindingAlgo;

import java.util.ArrayList;
import mainPackage.PathCircuit;


// 0 = Rien, 1 = Mur, 2 = Path, 3 = CheminExplorer
public class BreadthFirstSearchSam 
{
		public final int DROITE = 0;
		public final int GAUCHE = 1;
		public final int HAUT = 2;
		public final int BAS = 3;
	
		public int[][] findPath(PathCircuit c, int[][] circuit,int startX, int startY, int endX, int endY){
			int[][] solvedCircuit = circuit;
			
			
			expandFrontier(c,circuit,startX,startY,endX,endY);
			
			return solvedCircuit;
		}
		
		private void expandFrontier(PathCircuit c,int[][] circuit,int StartPosX, int StartPosY,int EndPosX, int EndPosY){
			ArrayList<CaseDuCircuit> newVoisins = new ArrayList<CaseDuCircuit>();
			ArrayList<CaseDuCircuit> exploredCases = new ArrayList<CaseDuCircuit>();
			CaseDuCircuit PathCase;
			
			exploredCases = findVoisin(circuit,new CaseDuCircuit(StartPosX,StartPosY,null));
			PathCase = exploredCases.get(0);
			
			for(int i=0;i<exploredCases.size();i++){
				if(exploredCases.get(i).getPosX() == EndPosX && exploredCases.get(i).getPosY() == EndPosY){
					PathCase = exploredCases.get(i);
					break;
				}
				if(circuit[exploredCases.get(i).getPosX()][exploredCases.get(i).getPosY()] == 3){
					//frontier.remove(i);
					continue;
				}
				
				//System.out.println(i + " (" + frontier.get(i).getPosX() + "," + frontier.get(i).getPosY() + ")");
				//JOptionPane.showConfirmDialog(null, frontier.get(i).getPosX() + " " + frontier.get(i).getPosY());
				//c.repaint();
				
				circuit[exploredCases.get(i).getPosX()][exploredCases.get(i).getPosY()] = 3;
				newVoisins = findVoisin(circuit,exploredCases.get(i));
				
				exploredCases.addAll(newVoisins);
			}
			
			while(PathCase.parent != null){
				circuit[PathCase.getPosX()][PathCase.getPosY()] = 2;
				PathCase = PathCase.getParent();
			}
		}
		
		private ArrayList<CaseDuCircuit> findVoisin(int[][] circuit, CaseDuCircuit circuitCase){
			ArrayList<CaseDuCircuit> voisinFind = new ArrayList<CaseDuCircuit>();
			
			if(circuitCase.getPosX()<circuit.length-1 && circuit[circuitCase.getPosX()+1][circuitCase.getPosY()]==0){
				voisinFind.add(new CaseDuCircuit(circuitCase.getPosX()+1,circuitCase.getPosY(),circuitCase));
			}
			if(circuitCase.getPosY()<circuit[0].length-1 && circuit[circuitCase.getPosX()][circuitCase.getPosY()+1]==0){
				voisinFind.add(new CaseDuCircuit(circuitCase.getPosX(),circuitCase.getPosY()+1,circuitCase));
			}
			if(circuitCase.getPosX()>0 && circuit[circuitCase.getPosX()-1][circuitCase.getPosY()]==0){
				voisinFind.add(new CaseDuCircuit(circuitCase.getPosX()-1,circuitCase.getPosY(),circuitCase));
			}
			if(circuitCase.getPosY()>0 && circuit[circuitCase.getPosX()][circuitCase.getPosY()-1]==0){
				voisinFind.add(new CaseDuCircuit(circuitCase.getPosX(),circuitCase.getPosY()-1,circuitCase));
			}
			
			return voisinFind;
		}
		
		//class interne
		public class CaseDuCircuit{
			private int posX;
			private int posY;
			private CaseDuCircuit parent;
			
			public CaseDuCircuit(int x, int y, CaseDuCircuit par){
				this.posX = x;
				this.posY = y;
				this.parent = par;
			}
			
			public int getPosX(){
				return this.posX;
			}
			
			public int getPosY(){
				return this.posY;
			}
			public CaseDuCircuit getParent(){
				return this.parent;
			}
		}
}
