import java.awt.Color;
import java.util.ArrayList;
import java.util.Random;

public class BodyGroup {
	//Attribut
	private static ArrayList<Body> bodyList = new ArrayList<Body>();
	
	public static int getSize(){
		return bodyList.size();
	}
	
	public static void fillNewSpace(int numberOfBody, int widthMax, int heightMax,double mass,double diameter){
		Random rand = new Random();

		bodyList.clear();
		
		for(int i=0;i<numberOfBody;i++){
			double randX = widthMax * rand.nextDouble();
			double randY = heightMax * rand.nextDouble();
			
			bodyList.add(new Body(randX,randY,0,0,mass,diameter,randomColorBody()));
		}
	}
	public static Color randomColorBody()
	{
		Random rand = new Random();
		int r=0,g=0,b=0;
		r=(int)rand.nextInt(Constantes.TONEMAX-Constantes.TONEMIN)+Constantes.TONEMIN;
		g=(int)rand.nextInt(Constantes.TONEMAX-Constantes.TONEMIN)+Constantes.TONEMIN;
		b=(int)rand.nextInt(Constantes.TONEMAX-Constantes.TONEMIN)+Constantes.TONEMIN;
		Color c = new Color(r,g,b);
		return c;
	}
	
	public static void updateSpace(){
		//add force+Collision
		for (int i = 0; i < bodyList.size(); i++) {
			bodyList.get(i).resetForce();
			for (int j = 0; j < bodyList.size(); j++) {
				if (i != j){
					if(bodyList.get(i).distanceTo(bodyList.get(j))<Constantes.HITBOX_DIAMETER && Constantes.COLLISION_ENABLED){
						bodyList.get(i).mergeWith(bodyList.get(j));
						bodyList.remove(j);
					}else{
						bodyList.get(i).addForce(bodyList.get(j));
					}
				}
			}
		}
		
		for (int i = 0; i < bodyList.size(); i++) {
			bodyList.get(i).update(Constantes.Delta_T);
		}
	}
	
	public static void print(){

		for (int i = 0; i < bodyList.size(); i++) {
			System.out.println("Body #" + i+ " : " + bodyList.get(i).toString());
		}
		
	}

	public static Body getBody(int index){
		return bodyList.get(index);
	}
}
