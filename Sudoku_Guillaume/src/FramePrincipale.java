import java.awt.Dimension;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

@SuppressWarnings("serial")
public class FramePrincipale extends JFrame implements Runnable{

	//Constante
	private final Dimension DIMENSION = new Dimension(600, 700);
	
	//Attribut
	private JPanel panneauPrincipal;  //pointera sur getContentPane()
	private JButton bGenerate;
	private JButton bGenerateSolution;
	private JButton bCheck;
	private SudokuGame gamePannel;
	
	public void run() {
		Dimension screenDimension = Toolkit.getDefaultToolkit().getScreenSize();
		
		//initialisation du panneau           
		panneauPrincipal = (JPanel)getContentPane();
		panneauPrincipal.setLayout(new BoxLayout(panneauPrincipal, BoxLayout.Y_AXIS));
		
		gamePannel = new SudokuGame();
		bGenerate = new JButton("Generate a sudoku");
		bGenerateSolution = new JButton("Generate Solution"); 
		bCheck = new JButton("Check");
		
		gamePannel.setAlignmentX(CENTER_ALIGNMENT);
		bGenerate.setAlignmentX(CENTER_ALIGNMENT);
		bGenerateSolution.setAlignmentX(CENTER_ALIGNMENT);
		bCheck.setAlignmentX(CENTER_ALIGNMENT);
		
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,20)));
		panneauPrincipal.add(gamePannel);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(bGenerate);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(bGenerateSolution);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		//panneauPrincipal.add(bCheck);
		
		bGenerate.addActionListener(new EcouteurBoutton());
		bGenerateSolution.addActionListener(new EcouteurBoutton());
		bCheck.addActionListener(new EcouteurBoutton());
		
        this.setSize(DIMENSION);
        setResizable(false);
        this.setLocation(screenDimension.width/2-this.getSize().width/2, screenDimension.height/2-this.getSize().height/2);
        setTitle("Sudoku");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
	}
	
	public class EcouteurBoutton implements ActionListener {

		public void actionPerformed(ActionEvent e) {
			
			if (e.getSource() == bGenerate){
				gamePannel.generateSudoku();
			}else if(e.getSource() == bGenerateSolution){
				gamePannel.generateSolution();
				gamePannel.SolutionCheck();
			}else if(e.getSource() == bCheck){
				gamePannel.SolutionCheck();
			}
		}
		
	}	
}
