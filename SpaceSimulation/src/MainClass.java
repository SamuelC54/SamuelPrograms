/*
 * Made by Bradley How and Samuel Croteau
 * 
 * Space Simulation
 */
public class MainClass {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		FramePrincipale g = new FramePrincipale();
		Thread t = new Thread(g);
		t.start();
	}

}
