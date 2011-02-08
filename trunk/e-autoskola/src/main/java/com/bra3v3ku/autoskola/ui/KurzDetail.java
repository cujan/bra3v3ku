package com.bra3v3ku.autoskola.ui;

import javax.swing.JPanel;
import java.awt.Dimension;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;

public class KurzDetail extends JPanel {
	private JTextField idTF;
	private JTextField zaciatokDatumTF;
	private JTextField denVykonavaniaTF;
	private JTextField hodinaVykonavaniaTF;
	private JTextField skupinyTF;
	private JTextField idInstruktorTF;

	/**
	 * Create the panel.
	 */
	public KurzDetail() {
		setSize(new Dimension(800, 600));
		setLayout(null);
		
		
		JLabel idL = new JLabel("ID:");
		idL.setHorizontalAlignment(SwingConstants.RIGHT);
		idL.setFont(new Font("Tahoma", Font.BOLD, 11));
		idL.setBounds(189, 8, 46, 14);
		add(idL);
		
		idTF = new JTextField();
		idTF.setBounds(240, 5, 86, 20);
		add(idTF);
		idTF.setColumns(10);
		
		JLabel zaciatokDatumL = new JLabel("D\u00E1tum za\u010Diatku kurzu:");
		zaciatokDatumL.setHorizontalAlignment(SwingConstants.RIGHT);
		zaciatokDatumL.setFont(new Font("Tahoma", Font.BOLD, 11));
		zaciatokDatumL.setBounds(72, 81, 163, 14);
		add(zaciatokDatumL);
		
		zaciatokDatumTF = new JTextField();
		zaciatokDatumTF.setBounds(245, 78, 86, 20);
		add(zaciatokDatumTF);
		zaciatokDatumTF.setColumns(10);
		
		JLabel denVykonavaniaL = new JLabel("De\u0148 vykon\u00E1vania kurzu:");
		denVykonavaniaL.setHorizontalAlignment(SwingConstants.RIGHT);
		denVykonavaniaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		denVykonavaniaL.setBounds(44, 123, 191, 14);
		add(denVykonavaniaL);
		
		denVykonavaniaTF = new JTextField();
		denVykonavaniaTF.setBounds(245, 120, 86, 20);
		add(denVykonavaniaTF);
		denVykonavaniaTF.setColumns(10);
		
		JLabel hodinaVykonavaniaL = new JLabel("Hodina vykon\u00E1vania kurzu:");
		hodinaVykonavaniaL.setHorizontalAlignment(SwingConstants.RIGHT);
		hodinaVykonavaniaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		hodinaVykonavaniaL.setBounds(44, 161, 191, 14);
		add(hodinaVykonavaniaL);
		
		hodinaVykonavaniaTF = new JTextField();
		hodinaVykonavaniaTF.setBounds(240, 158, 86, 20);
		add(hodinaVykonavaniaTF);
		hodinaVykonavaniaTF.setColumns(10);
		
		JLabel skupinyL = new JLabel("Skupiny:");
		skupinyL.setHorizontalAlignment(SwingConstants.RIGHT);
		skupinyL.setFont(new Font("Tahoma", Font.BOLD, 11));
		skupinyL.setBounds(121, 197, 114, 14);
		add(skupinyL);
		
		skupinyTF = new JTextField();
		skupinyTF.setBounds(240, 194, 86, 20);
		add(skupinyTF);
		skupinyTF.setColumns(10);
		
		JLabel idInstruktorL = new JLabel("ID Instruktor:");
		idInstruktorL.setHorizontalAlignment(SwingConstants.RIGHT);
		idInstruktorL.setFont(new Font("Tahoma", Font.BOLD, 11));
		idInstruktorL.setBounds(110, 233, 125, 14);
		add(idInstruktorL);
		
		idInstruktorTF = new JTextField();
		idInstruktorTF.setBounds(245, 230, 86, 20);
		add(idInstruktorTF);
		idInstruktorTF.setColumns(10);

	}
}
