import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;
import javax.swing.JPanel;

public class SpacePanel extends JPanel {
	//Constante
	public int PAN_WIDTH = 900;
	public int PAN_HEIGHT = 600;
	
	public SpacePanel(){
		this.setMaximumSize(new Dimension(PAN_WIDTH, PAN_HEIGHT));
		this.setMinimumSize(new Dimension(PAN_WIDTH, PAN_HEIGHT));
		this.setPreferredSize(new Dimension(PAN_WIDTH, PAN_HEIGHT));
	}
	
	public void paint(Graphics g) {
		Graphics2D g2d = (Graphics2D) g;
		g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

		int panWidth = (this.getWidth());
		int panHeight = (this.getHeight());
		
		//background
		g.setColor(Color.BLACK);
		g2d.fillRect(0, 0, panWidth, panHeight);
		
		//Paint Asteroid
		for(int i=0; i < BodyGroup.getSize(); i++){
			Body currentBody = BodyGroup.getBody(i);
			g.setColor(currentBody.getColor());
			int posX = (int)currentBody.getPx();
			int posY = (int)currentBody.getPy();
			int diameter = (int)currentBody.getDiameter()*Constantes.ZOOM_MULTIPLIER;
		    g.fillOval(posX-diameter/2,posY-diameter/2,diameter,diameter);
		}
	}
}
