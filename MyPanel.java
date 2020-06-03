package MouseListener;

import java.awt.Color;

import java.awt.Graphics;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;

import javax.swing.BorderFactory;
import javax.swing.JPanel;


public class MyPanel extends JPanel {
	private int posX = 50;
	private int posY = 50;
	private int Width = 20;
	private int Height = 20;
	
	public MyPanel(){
		
		setBorder(BorderFactory.createLineBorder(Color.BLACK));
		
		addMouseListener(new MouseAdapter() {
			public void mousePressed(MouseEvent e){
				moveControl(e.getX(),e.getY());
			}
		});
		
		
	}
	private void moveControl(int x,int y) {
		if((posX !=x) || (posY !=y)){
			repaint();
			posX = x;
			posY = y;
			repaint(posX,posY,Width,Height);
		}
	}
	
	
	public void paintComponent(Graphics g){
		super.paintComponent(g);
		g.setColor(Color.BLACK);
		g.drawLine(0, 0, 50, 100);
	}
}
