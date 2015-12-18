import javax.swing.JPanel;

public class SimulationThread implements Runnable{

	private JPanel panneauPrincipal;
	private volatile boolean threadEnable;
	
	public SimulationThread(JPanel pan){
		this.panneauPrincipal = pan;
		threadEnable=false;
	}
	
	public void run() {
		while(true){
			while(threadEnable){
					BodyGroup.updateSpace();
					//System.out.println(BodyGroup.getBody(0).toString());
					panneauPrincipal.repaint();
			}
		}
	}
	
	public void setEnable(boolean state){
		this.threadEnable = state;
	}
}
