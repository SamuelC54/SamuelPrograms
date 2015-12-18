import java.awt.Color;

public class Body {
	  
	private double px, py;    // positions
	private double vx, vy;    // vitesse
	private double fx, fy;    // force 
	private double mass;      // mass
	private double diameter;  // mass
	private Color color;
	
	public Body(double px, double py, double vx, double vy, double mass,double diameter, Color color){
		this.px= px;
		this.py= py;
		this.vx= vx;
		this.vy= vy;
		this.mass = mass;
		this.diameter = diameter;
		this.color = color;
	}

	public void update(double dt) {
		vx += dt * fx / mass;
		vy += dt * fy / mass;
		px += dt * vx;
		py += dt * vy;
		
		if(Constantes.TELEPORTATION_WALL){
			int PAN_WIDTH = 900;
			int PAN_HEIGHT = 680;
			if(px>PAN_WIDTH){px = 0;}
			if(px<0){px = PAN_WIDTH;}
			if(py>PAN_HEIGHT){py = 0;}
			if(py<0){py = PAN_HEIGHT;}
		}
	}
	
	public double distanceTo(Body b) {
		double dx = px - b.getPx();
		double dy = py - b.getPy();
		return Math.sqrt(dx*dx + dy*dy);
	}
	
	public void mergeWith(Body b) {
		this.vx += (b.getVx()*b.getMass())/this.mass;
		this.vy += (b.getVy()*b.getMass())/this.mass; 
		this.diameter += b.getDiameter();
		this.mass += b.getMass();
		this.setColor(new Color(((this.color.getRed()+b.color.getRed())/2),
				((this.color.getGreen()+b.color.getGreen())/2),
				((this.color.getBlue()+b.color.getBlue())/2)));
	}
	
	public void resetForce() {
		fx = 0.0;
		fy = 0.0;
	}

	public void addForce(Body b) {
		Body a = this;
		double EPS = 3*Math.pow(10, 4);      // softening parameter (pour pas avoir infini)
		double dx = b.getPx() - a.getPx();
		double dy = b.getPy() - a.getPy();
		double dist = Math.sqrt(dx*dx + dy*dy);
		double F = (Constantes.G * a.mass * b.mass) / (dist*dist + EPS*EPS);
		a.fx += F * dx / dist;
		a.fy += F * dy / dist;
	}
	
	public String toString() {
		return "" + px + ", "+ py+ ", "+  vx+ ", "+ vy+ ", "+ mass;
	}
	  
	//getter
	public double getMass(){
		return this.mass;
	}
	public double getPx(){
		return this.px;
	}
	public double getPy(){
		return this.py;
	}
	public double getVx(){
		return this.vx;
	}
	public double getVy(){
		return this.vy;
	}
	public double getFx(){
		return this.fx;
	}
	public double getFy(){
		return this.fy;
	}
	public Color getColor(){
		return this.color;
	}
	public double getDiameter(){
		return this.diameter;
	}
	//setter
	public void setMass(double mass){
		this.mass = mass;
	}
	public void setPx(double px){
		this.px = px;
	}
	public void setPy(double py){
		this.py = py;
	}
	public void setColor(Color color){
		this.color = color;
	}
}
