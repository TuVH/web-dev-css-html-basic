package MouseListener;


import javax.swing.JFrame;

public class Main extends JFrame{
	public static void main(String[] args) {
		Main m = new Main();
		m.setVisible(true);
	}
	private Main(){
		 setTitle("Mouse");
	     setSize(500, 600);
	     setDefaultCloseOperation(EXIT_ON_CLOSE);
	     setLocationRelativeTo(null);
	        
	     MyPanel panel = new MyPanel();
	     add(panel);
	}

}
