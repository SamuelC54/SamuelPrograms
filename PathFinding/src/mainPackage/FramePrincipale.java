package mainPackage;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

import samPathFindingAlgo.*;

public class FramePrincipale extends JFrame implements Runnable{

	//Constante
	private final Dimension DIMENSION = new Dimension(600, 850);
	private final int CIRCUIT_SIZE_X = 20;
	private final int CIRCUIT_SIZE_Y = 20;
	private final int PANNEL_SIZE = 400;
	
	//Attribut
	private JPanel panneauPrincipal;  //pointera sur getContentPane()
	private JPanel panneauBoutton;
	private JPanel panneauGroupConstantes;
	private JPanel panneauBouttonAlgoSam;
	private JPanel panneauBouttonAlgoBrad;
	private JButton bClearAll;
	private JButton bClearPath;
	private JButton bBreadthFirstSearchS;
	private JButton bAStarS;
	private JButton bDijkstraS;
	private JButton bConcurrentS;
	private JButton bAStarB;
	private JButton bDijkstraB;
	private JButton bConcurrentB;
	private JLabel lbSamAlgo;
	private JLabel lbBradAlgo;
	private JButton bUpdate;
	private PathCircuit circuit;
	private TexFieldWithLabel tbStartingPointX;
	private TexFieldWithLabel tbStartingPointY;
	private TexFieldWithLabel tbEndingPointX;
	private TexFieldWithLabel tbEndingPointY;
	
	public void run() {
		Dimension screenDimension = Toolkit.getDefaultToolkit().getScreenSize();
		
		//initialisation du panneau           
		panneauPrincipal = (JPanel)this.getContentPane();
		panneauPrincipal.setLayout(new BoxLayout(panneauPrincipal, BoxLayout.Y_AXIS));

		circuit = new PathCircuit(CIRCUIT_SIZE_X,CIRCUIT_SIZE_Y,PANNEL_SIZE); 
		bClearAll = new JButton("Clear ALL");
		bClearPath = new JButton("Clear Path Only"); 
		bBreadthFirstSearchS = new JButton("Solve with Breadth First Search");
		bAStarS = new JButton("Solve with A*");
		bDijkstraS = new JButton("Solve with Dijkstra"); 
		bConcurrentS = new JButton("Solve with Concurrent");
		bAStarB = new JButton("Solve with A*");
		bDijkstraB = new JButton("Solve with Dijkstra"); 
		bConcurrentB = new JButton("Solve with Concurrent");
		lbSamAlgo = new JLabel("Sam's Algorithm");
		lbBradAlgo = new JLabel("Brad's Algorithm");
		panneauBoutton = new JPanel(new FlowLayout(FlowLayout.CENTER,0,0));
		panneauGroupConstantes = new JPanel(new FlowLayout(FlowLayout.CENTER, 0, 0));
		panneauBouttonAlgoSam = new JPanel(new FlowLayout(FlowLayout.CENTER,0,0));
		panneauBouttonAlgoBrad = new JPanel(new FlowLayout(FlowLayout.CENTER,0,0));
		tbStartingPointX=new TexFieldWithLabel("Starting point (X):");
		tbStartingPointY=new TexFieldWithLabel("Starting point (Y):");		
		tbEndingPointX=new TexFieldWithLabel("Ending point (X):");
		tbEndingPointY=new TexFieldWithLabel("Ending point (Y):");
		bUpdate = new JButton("Update the variables");
		
		circuit.setAlignmentX(CENTER_ALIGNMENT);
		bClearAll.setAlignmentX(CENTER_ALIGNMENT);
		bClearPath.setAlignmentX(CENTER_ALIGNMENT);
		bUpdate.setAlignmentX(CENTER_ALIGNMENT);
		panneauBoutton.setAlignmentX(CENTER_ALIGNMENT);
		panneauGroupConstantes.setAlignmentX(CENTER_ALIGNMENT);
		panneauBouttonAlgoSam.setAlignmentX(CENTER_ALIGNMENT);
		panneauBouttonAlgoBrad.setAlignmentX(CENTER_ALIGNMENT);
		lbSamAlgo.setAlignmentX(CENTER_ALIGNMENT);
		lbBradAlgo.setAlignmentX(CENTER_ALIGNMENT);
		
		panneauBoutton.setMaximumSize(new Dimension((int) panneauBoutton.getMaximumSize().getWidth(), 30));
		panneauBoutton.add(bClearAll);
		panneauBoutton.add(bClearPath);
		
		panneauBouttonAlgoSam.setMaximumSize(new Dimension((int) panneauBouttonAlgoSam.getMaximumSize().getWidth(), 60));
		panneauBouttonAlgoSam.add(bBreadthFirstSearchS);
		panneauBouttonAlgoSam.add(bAStarS);
		panneauBouttonAlgoSam.add(bDijkstraS);
		panneauBouttonAlgoSam.add(bConcurrentS);
		
		panneauBouttonAlgoBrad.setMaximumSize(new Dimension((int) panneauBouttonAlgoBrad.getMaximumSize().getWidth(), 30));
		panneauBouttonAlgoBrad.add(bAStarB);
		panneauBouttonAlgoBrad.add(bDijkstraB);
		panneauBouttonAlgoBrad.add(bConcurrentB);
		
		panneauGroupConstantes.setMaximumSize(new Dimension((int) panneauGroupConstantes.getMaximumSize().getWidth(), 60));
		panneauGroupConstantes.add(tbStartingPointX);
		panneauGroupConstantes.add(tbStartingPointY);
		panneauGroupConstantes.add(tbEndingPointX);
		panneauGroupConstantes.add(tbEndingPointY);
		
		
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,20)));
		panneauPrincipal.add(circuit);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(panneauBoutton);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(lbSamAlgo);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(panneauBouttonAlgoSam);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(lbBradAlgo);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(panneauBouttonAlgoBrad);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(panneauGroupConstantes);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(bUpdate);
		
		
		bClearAll.addActionListener(new EcouteurBoutton());
		bClearPath.addActionListener(new EcouteurBoutton());
		bUpdate.addActionListener(new EcouteurBoutton());
		bBreadthFirstSearchS.addActionListener(new EcouteurBoutton());
		bAStarS.addActionListener(new EcouteurBoutton());
		bDijkstraS.addActionListener(new EcouteurBoutton());
		bConcurrentS.addActionListener(new EcouteurBoutton());
		
		//initTextField();
		
        this.setSize(DIMENSION);
        setResizable(false);
        this.setLocation(screenDimension.width/2-this.getSize().width/2, screenDimension.height/2-this.getSize().height/2);
        setTitle("Path Finding Tester");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
	}
	
	public class EcouteurBoutton implements ActionListener {

		public void actionPerformed(ActionEvent e) {
			
			if (e.getSource() == bClearAll){
				circuit.clearAll();
			}else if(e.getSource() == bClearPath){
				circuit.clearPath();
			}else if(e.getSource() == bBreadthFirstSearchS){
				circuit.clearPath();
				BreadthFirstSearchSam algo = new BreadthFirstSearchSam();
				circuit.setCircuit(algo.findPath(circuit,circuit.getCircuit(),circuit.getStartPosX(),circuit.getStartPosY(),circuit.getEndPosX(),circuit.getEndPosY()));
			}else if(e.getSource() == bAStarS){
				circuit.setCircuit(AStarSam.findPath(circuit.getCircuit(),circuit.getStartPosX(),circuit.getStartPosY(),circuit.getEndPosX(),circuit.getEndPosY()));
			}else if(e.getSource() == bUpdate){
			}
		}
	}	

	public void initTextField(){
		tbStartingPointX.setText("0");
		tbStartingPointY.setText("0");
		tbEndingPointX.setText(String.valueOf(CIRCUIT_SIZE_X));
		tbEndingPointY.setText(String.valueOf(CIRCUIT_SIZE_Y));
	}
	public void updateC(){
		
	}
	
}
