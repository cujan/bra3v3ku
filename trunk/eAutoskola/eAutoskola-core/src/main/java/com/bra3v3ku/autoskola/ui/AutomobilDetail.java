package com.bra3v3ku.autoskola.ui;

import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.Dimension;
import java.awt.EventQueue;

import javax.swing.JLabel;
import java.awt.Component;
import javax.swing.SwingConstants;
import java.awt.Font;
import javax.swing.JTextField;

import com.bra3v3ku.autoskola.dao.Automobil;
import com.bra3v3ku.autoskola.dao.generic.BasicDao;
import com.bra3v3ku.autoskola.dao.generic.BasicDaoImpl;

public class AutomobilDetail extends JFrame{
	private static final String PERSISTENCE_UNIT_NAME = "eAutoskola";
	private BasicDao<Automobil, Integer> autoDao= new BasicDaoImpl<Automobil,Integer>(PERSISTENCE_UNIT_NAME);
	private JTextField idTF;
	private JTextField znackaTF;
	private JTextField modelTF;
	private JTextField spzTF;
	private JTextField priemernaSpotrebaTF;
	private JTextField stkPlatnostTF;
	private JTextField ekPlatnostTF;
	private JTextField vinTF;

	public static void main(final Integer arg) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AutomobilDetail frame = new AutomobilDetail(arg);
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	/**
	 * Create the panel.
	 */
	public AutomobilDetail(Integer id) {
		Automobil auto = autoDao.getEntityByID(Automobil.class, id);
		setSize(new Dimension(800, 600));
		setLayout(null);
		
		JLabel idL = new JLabel("ID:");
		idL.setFont(new Font("Tahoma", Font.BOLD, 11));
		idL.setHorizontalAlignment(SwingConstants.RIGHT);
		idL.setAlignmentX(Component.RIGHT_ALIGNMENT);
		idL.setBounds(181, 61, 46, 14);
		add(idL);
		
		idTF = new JTextField();
		idTF.setBounds(237, 58, 46, 20);
		add(idTF);
		idTF.setColumns(10);
		
		JLabel znackaL = new JLabel("Zna\u010Dka:");
		znackaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		znackaL.setHorizontalAlignment(SwingConstants.RIGHT);
		znackaL.setBounds(181, 89, 46, 14);
		add(znackaL);
		
		znackaTF = new JTextField();
		znackaTF.setBounds(237, 86, 86, 20);
		add(znackaTF);
		znackaTF.setColumns(10);
		
		JLabel modelL = new JLabel("Model:");
		modelL.setFont(new Font("Tahoma", Font.BOLD, 11));
		modelL.setHorizontalAlignment(SwingConstants.RIGHT);
		modelL.setBounds(426, 89, 46, 14);
		add(modelL);
		
		modelTF = new JTextField();
		modelTF.setBounds(482, 86, 86, 20);
		add(modelTF);
		modelTF.setColumns(10);
		
		JLabel spzL = new JLabel("SPZ:");
		spzL.setFont(new Font("Tahoma", Font.BOLD, 11));
		spzL.setHorizontalAlignment(SwingConstants.RIGHT);
		spzL.setBounds(181, 117, 46, 14);
		add(spzL);
		
		spzTF = new JTextField();
		spzTF.setBounds(237, 114, 86, 20);
		add(spzTF);
		spzTF.setColumns(10);
		
		JLabel priemernaSpotrebaL = new JLabel("Priemern\u00E1 spotreba:");
		priemernaSpotrebaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		priemernaSpotrebaL.setHorizontalAlignment(SwingConstants.RIGHT);
		priemernaSpotrebaL.setBounds(341, 117, 131, 14);
		add(priemernaSpotrebaL);
		
		priemernaSpotrebaTF = new JTextField();
		priemernaSpotrebaTF.setBounds(482, 114, 86, 20);
		add(priemernaSpotrebaTF);
		priemernaSpotrebaTF.setColumns(10);
		
		JLabel stkPlatnostL = new JLabel("STK platnos\u0165:");
		stkPlatnostL.setFont(new Font("Tahoma", Font.BOLD, 11));
		stkPlatnostL.setHorizontalAlignment(SwingConstants.RIGHT);
		stkPlatnostL.setBounds(130, 145, 97, 14);
		add(stkPlatnostL);
		
		stkPlatnostTF = new JTextField();
		stkPlatnostTF.setBounds(237, 142, 86, 20);
		add(stkPlatnostTF);
		stkPlatnostTF.setColumns(10);
		
		JLabel ekPlatnostL = new JLabel("EK platnos\u0165:");
		ekPlatnostL.setFont(new Font("Tahoma", Font.BOLD, 11));
		ekPlatnostL.setHorizontalAlignment(SwingConstants.RIGHT);
		ekPlatnostL.setBounds(386, 145, 86, 14);
		add(ekPlatnostL);
		
		ekPlatnostTF = new JTextField();
		ekPlatnostTF.setBounds(482, 142, 86, 20);
		add(ekPlatnostTF);
		ekPlatnostTF.setColumns(10);
		
		JLabel vinL = new JLabel("VIN:");
		vinL.setFont(new Font("Tahoma", Font.BOLD, 11));
		vinL.setHorizontalAlignment(SwingConstants.RIGHT);
		vinL.setBounds(181, 173, 46, 14);
		add(vinL);
		
		vinTF = new JTextField();
		vinTF.setBounds(237, 170, 86, 20);
		add(vinTF);
		vinTF.setColumns(10);
		
		znackaTF.setText(auto.getZnacka());
		modelTF.setText(auto.getModel());

	}
}
