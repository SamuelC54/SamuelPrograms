import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class FramePrincipale extends JFrame implements Runnable{
	//constante
		
	//attribut
	private JPanel panneauPrincipal;
	private SpacePanel panneauSpace;
	private JButton bFill;
	private JButton bStart;
	private JButton bStop;
	private JButton bUpdate;
	private JPanel panneauGroupStartStop;
	private JPanel panneauGroupConstantes;
	private TexFieldWithLabel tbConstanteG;
	private TexFieldWithLabel tbConstanteDeltaT;
	private TexFieldWithLabel tbConstanteNumberOfBody;
	private TexFieldWithLabel tbConstanteStartingMass;
	private TexFieldWithLabel tbConstanteStartingDiameter;
	private TexFieldWithLabel tbConstanteZoomMultiplier;
	private TexFieldWithLabel tbConstanteToneMin;
	private TexFieldWithLabel tbConstanteTonMax;
	private TexFieldWithLabel tbConstanteHitboxDiameter;
	private TexFieldWithLabel tbConstanteTeleportationWall;
	private TexFieldWithLabel tbConstanteCollisionEnabled;
	
	
	SimulationThread simThreadClass;
	Thread simThread;
	
	public void run() {
		Dimension screenDimension = Toolkit.getDefaultToolkit().getScreenSize();
		
		panneauPrincipal = (JPanel)this.getContentPane();
		simThreadClass = new SimulationThread(panneauPrincipal);
		simThread = new Thread(simThreadClass);
		
		panneauSpace = new SpacePanel();
		bFill = new JButton("Fill the Space!");
		bStart = new JButton("Start the Simulation!");
		bStop = new JButton("Stop the Simulation!");
		bUpdate = new JButton("Update the variable");
		panneauGroupStartStop = new JPanel(new FlowLayout(FlowLayout.CENTER, 0, 0));
		panneauGroupConstantes = new JPanel(new FlowLayout(FlowLayout.CENTER, 0, 0));
		tbConstanteG = new TexFieldWithLabel("G");
		tbConstanteDeltaT = new TexFieldWithLabel("Delta T");
		tbConstanteNumberOfBody = new TexFieldWithLabel("Number Of Body");
		tbConstanteStartingMass = new TexFieldWithLabel("Starting Mass");
		tbConstanteStartingDiameter = new TexFieldWithLabel("Starting Diameter");
		tbConstanteZoomMultiplier = new TexFieldWithLabel("Zoom Multiplier");
		tbConstanteToneMin = new TexFieldWithLabel("Tone Min");
		tbConstanteTonMax = new TexFieldWithLabel("Ton Max");
		tbConstanteHitboxDiameter = new TexFieldWithLabel("Hitbox Diameter");
		tbConstanteTeleportationWall = new TexFieldWithLabel("Teleportation Wall");
		tbConstanteCollisionEnabled = new TexFieldWithLabel("Collision Enabled");
		
		panneauPrincipal.setLayout(new BoxLayout(panneauPrincipal, BoxLayout.Y_AXIS));
		
		panneauSpace.setAlignmentX(CENTER_ALIGNMENT);
		bFill.setAlignmentX(CENTER_ALIGNMENT);
		bUpdate.setAlignmentX(CENTER_ALIGNMENT);
		panneauGroupStartStop.setAlignmentX(CENTER_ALIGNMENT);
		panneauGroupConstantes.setAlignmentX(CENTER_ALIGNMENT);
		
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,20)));
		panneauPrincipal.add(panneauSpace);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(bFill);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauGroupStartStop.setMaximumSize(new Dimension((int) panneauGroupStartStop.getMaximumSize().getWidth(), 40));
		panneauPrincipal.add(panneauGroupStartStop);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,0)));
		panneauGroupConstantes.setMaximumSize(new Dimension((int) panneauGroupConstantes.getMaximumSize().getWidth(), 90));
		panneauPrincipal.add(panneauGroupConstantes);
		panneauPrincipal.add(Box.createRigidArea(new Dimension(0,10)));
		panneauPrincipal.add(bUpdate);
		
		//START and STOP bouton
		panneauGroupStartStop.add(bStart);
		panneauGroupStartStop.add(bStop);
		
		bStop.setEnabled(false);
		
		bFill.addActionListener(new EcouteurBoutton());
		bStart.addActionListener(new EcouteurBoutton());
		bStop.addActionListener(new EcouteurBoutton());
		bUpdate.addActionListener(new EcouteurBoutton());
		//Constantes Text Field
		panneauGroupConstantes.add(tbConstanteG);
		panneauGroupConstantes.add(tbConstanteDeltaT);
		panneauGroupConstantes.add(tbConstanteNumberOfBody);
		panneauGroupConstantes.add(tbConstanteStartingMass);
		panneauGroupConstantes.add(tbConstanteStartingDiameter);
		panneauGroupConstantes.add(tbConstanteZoomMultiplier);
		panneauGroupConstantes.add(tbConstanteToneMin);
		panneauGroupConstantes.add(tbConstanteTonMax);
		panneauGroupConstantes.add(tbConstanteHitboxDiameter);
		panneauGroupConstantes.add(tbConstanteTeleportationWall);
		panneauGroupConstantes.add(tbConstanteCollisionEnabled);
		
		initTextField();
		
		//Other
		
		this.setSize(new Dimension(1000,900));
		this.setLocation(screenDimension.width/2-this.getSize().width/2, screenDimension.height/2-this.getSize().height/2);
        setResizable(false);
        setTitle("Brute-Force - N-Body Simulation");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
	}

	public class EcouteurBoutton implements ActionListener {

		public void actionPerformed(ActionEvent e) {

			if (e.getSource() == bFill){
				BodyGroup.fillNewSpace(Constantes.NUMBERS_OF_BODY, panneauSpace.PAN_WIDTH,panneauSpace.PAN_HEIGHT,Constantes.STARTING_MASS,Constantes.STARTING_DIAMETER);
				panneauPrincipal.repaint();
				bStart.setEnabled(true);
			}else if(e.getSource() == bStart){
				if(simThread.getState() == Thread.State.NEW){
					System.out.println("Thread Started");
					simThread.start();
				}
				simThreadClass.setEnable(true);
				bStart.setEnabled(false);
				bFill.setEnabled(false);
				bStop.setEnabled(true);
				bUpdate.setEnabled(false);
			}else if(e.getSource() == bStop){
				simThreadClass.setEnable(false);
				bStart.setEnabled(true);
				bFill.setEnabled(true);
				bStop.setEnabled(false);
				bUpdate.setEnabled(true);
			}else if(e.getSource() == bUpdate){
				updateTextField();
				bStart.setEnabled(false);
			}
		}
	}
	
	public void initTextField(){
		tbConstanteG.setText(String.valueOf(Constantes.G));
		tbConstanteDeltaT.setText(String.valueOf(Constantes.Delta_T));
		tbConstanteNumberOfBody.setText(String.valueOf(Constantes.NUMBERS_OF_BODY));
		tbConstanteStartingMass.setText(String.valueOf(Constantes.STARTING_MASS));
		tbConstanteStartingDiameter.setText(String.valueOf(Constantes.STARTING_DIAMETER));
		tbConstanteZoomMultiplier.setText(String.valueOf(Constantes.ZOOM_MULTIPLIER));
		tbConstanteToneMin.setText(String.valueOf(Constantes.TONEMIN));
		tbConstanteTonMax.setText(String.valueOf(Constantes.TONEMAX));
		tbConstanteHitboxDiameter.setText(String.valueOf(Constantes.HITBOX_DIAMETER));
		tbConstanteTeleportationWall.getJTextField().setText(String.valueOf(Constantes.TELEPORTATION_WALL));
		tbConstanteCollisionEnabled.setText(String.valueOf(Constantes.COLLISION_ENABLED));
	}
	
	public void updateTextField(){
		Constantes.G = Double.parseDouble(tbConstanteG.getText());
		Constantes.Delta_T = Double.parseDouble(tbConstanteDeltaT.getText());
		Constantes.NUMBERS_OF_BODY = Integer.parseInt(tbConstanteNumberOfBody.getText());
		Constantes.STARTING_MASS = Double.parseDouble(tbConstanteStartingMass.getText());
		Constantes.STARTING_DIAMETER = Double.parseDouble(tbConstanteStartingDiameter.getText());
		Constantes.ZOOM_MULTIPLIER = Integer.parseInt(tbConstanteZoomMultiplier.getText());
		Constantes.TONEMIN = Integer.parseInt(tbConstanteToneMin.getText());
		Constantes.TONEMAX = Integer.parseInt(tbConstanteTonMax.getText());
		Constantes.HITBOX_DIAMETER = Integer.parseInt(tbConstanteHitboxDiameter.getText());
		Constantes.TELEPORTATION_WALL = Boolean.parseBoolean(tbConstanteTeleportationWall.getText());
		Constantes.COLLISION_ENABLED = Boolean.parseBoolean(tbConstanteCollisionEnabled.getText());
	}
}
