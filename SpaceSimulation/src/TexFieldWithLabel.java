import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class TexFieldWithLabel extends JPanel  {
	JLabel label; 
	JTextField textField;
	
	public TexFieldWithLabel(String labelText){
		label = new JLabel(labelText);
		textField = new JTextField(10);
		
		this.add(label);
		this.add(textField);
	}
	
	public JTextField getJTextField(){
		return this.textField;
	}
	
	public void setText(String input){
		textField.setText(input);
	}
	
	public String getText(){
		return textField.getText();
	}
}
