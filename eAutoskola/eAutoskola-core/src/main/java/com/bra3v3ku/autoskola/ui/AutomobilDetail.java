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
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class AutomobilDetail extends JFrame{
	private static final String PERSISTENCE_UNIT_NAME = "eAutoskolaDerby";
	private BasicDao<Automobil, Integer> autoDao= new BasicDaoImpl<Automobil,Integer>(PERSISTENCE_UNIT_NAME);
	private JTextField idTF;
	private JTextField znackaTF;
	private JTextField modelTF;
	private JTextField spzTF;
	private JTextField priemernaSpotrebaTF;
	private JTextField stkPlatnostTF;
	private JTextField ekPlatnostTF;
	private JTextField vinTF;
	private JButton saveBtn;

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

		setSize(new Dimension(800, 600));
		getContentPane().setLayout(null);
		
		JLabel idL = new JLabel("ID:");
		idL.setFont(new Font("Tahoma", Font.BOLD, 11));
		idL.setHorizontalAlignment(SwingConstants.RIGHT);
		idL.setAlignmentX(Component.RIGHT_ALIGNMENT);
		idL.setBounds(181, 61, 46, 14);
		getContentPane().add(idL);
		
		idTF = new JTextField();
		idTF.setEditable(false);
		idTF.setBounds(237, 58, 46, 20);
		getContentPane().add(idTF);
		idTF.setColumns(10);
		
		JLabel znackaL = new JLabel("Zna\u010Dka:");
		znackaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		znackaL.setHorizontalAlignment(SwingConstants.RIGHT);
		znackaL.setBounds(181, 89, 46, 14);
		getContentPane().add(znackaL);
		
		znackaTF = new JTextField();
		znackaTF.setEditable(false);
		znackaTF.setBounds(237, 86, 86, 20);
		getContentPane().add(znackaTF);
		znackaTF.setColumns(10);
		
		JLabel modelL = new JLabel("Model:");
		modelL.setFont(new Font("Tahoma", Font.BOLD, 11));
		modelL.setHorizontalAlignment(SwingConstants.RIGHT);
		modelL.setBounds(426, 89, 46, 14);
		getContentPane().add(modelL);
		
		modelTF = new JTextField();
		modelTF.setEditable(false);
		modelTF.setBounds(482, 86, 86, 20);
		getContentPane().add(modelTF);
		modelTF.setColumns(10);
		
		JLabel spzL = new JLabel("SPZ:");
		spzL.setFont(new Font("Tahoma", Font.BOLD, 11));
		spzL.setHorizontalAlignment(SwingConstants.RIGHT);
		spzL.setBounds(181, 117, 46, 14);
		getContentPane().add(spzL);
		
		spzTF = new JTextField();
		spzTF.setEditable(false);
		spzTF.setBounds(237, 114, 86, 20);
		getContentPane().add(spzTF);
		spzTF.setColumns(10);
		
		JLabel priemernaSpotrebaL = new JLabel("Priemern\u00E1 spotreba:");
		priemernaSpotrebaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		priemernaSpotrebaL.setHorizontalAlignment(SwingConstants.RIGHT);
		priemernaSpotrebaL.setBounds(341, 117, 131, 14);
		getContentPane().add(priemernaSpotrebaL);
		
		priemernaSpotrebaTF = new JTextField();
		priemernaSpotrebaTF.setEditable(false);
		priemernaSpotrebaTF.setBounds(482, 114, 86, 20);
		getContentPane().add(priemernaSpotrebaTF);
		priemernaSpotrebaTF.setColumns(10);
		
		JLabel stkPlatnostL = new JLabel("STK platnos\u0165:");
		stkPlatnostL.setFont(new Font("Tahoma", Font.BOLD, 11));
		stkPlatnostL.setHorizontalAlignment(SwingConstants.RIGHT);
		stkPlatnostL.setBounds(130, 145, 97, 14);
		getContentPane().add(stkPlatnostL);
		
		stkPlatnostTF = new JTextField();
		stkPlatnostTF.setEditable(false);
		stkPlatnostTF.setBounds(237, 142, 86, 20);
		getContentPane().add(stkPlatnostTF);
		stkPlatnostTF.setColumns(10);
		
		JLabel ekPlatnostL = new JLabel("EK platnos\u0165:");
		ekPlatnostL.setFont(new Font("Tahoma", Font.BOLD, 11));
		ekPlatnostL.setHorizontalAlignment(SwingConstants.RIGHT);
		ekPlatnostL.setBounds(386, 145, 86, 14);
		getContentPane().add(ekPlatnostL);
		
		ekPlatnostTF = new JTextField();
		ekPlatnostTF.setEditable(false);
		ekPlatnostTF.setBounds(482, 142, 86, 20);
		getContentPane().add(ekPlatnostTF);
		ekPlatnostTF.setColumns(10);
		
		JLabel vinL = new JLabel("VIN:");
		vinL.setFont(new Font("Tahoma", Font.BOLD, 11));
		vinL.setHorizontalAlignment(SwingConstants.RIGHT);
		vinL.setBounds(181, 173, 46, 14);
		getContentPane().add(vinL);
		
		vinTF = new JTextField();
		vinTF.setEditable(false);
		vinTF.setBounds(237, 170, 86, 20);
		getContentPane().add(vinTF);
		vinTF.setColumns(10);
		
		saveBtn = new JButton("Ulozit");
		saveBtn.setEnabled(false);
		saveBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Automobil auto = getFields();
				if (idTF.getText()!=""){
					autoDao.update(auto);					
				} else {
					autoDao.insert(auto);
				}
			}
		});
		saveBtn.setBounds(237, 11, 89, 23);
		getContentPane().add(saveBtn);		
		
		JButton editBtn = new JButton("Editovat");
		editBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				saveBtn.setEnabled(true);
				editable();				
			}
		});
		
		editBtn.setBounds(130, 11, 89, 23);
		getContentPane().add(editBtn);
		
		JButton deleteBtn = new JButton("Vymazat");
		deleteBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				autoDao.delete(autoDao.getEntityByID(Automobil.class, Integer.valueOf(idTF.getText())));
			}
		});
		deleteBtn.setBounds(333, 11, 89, 23);
		getContentPane().add(deleteBtn);
		
		if (id !=-1){
			editBtn.setVisible(true);
			Automobil auto = autoDao.getEntityByID(Automobil.class, id);
			setFields(auto);
			notEditable();
		} else {
			editBtn.setVisible(false);
			deleteBtn.setVisible(false);
			setFields(new Automobil());
			saveBtn.setEnabled(true);
			editable();
		}
		

	}
	
	private Automobil getFields(){
		Automobil auto = new Automobil();
		auto.setModel(modelTF.getText());
		auto.setZnacka(znackaTF.getText());
		auto.setSpz(spzTF.getText());
		return auto;
	}
	
	private void setFields(Automobil auto){
		idTF.setText(String.valueOf(auto.getId()));
		modelTF.setText(auto.getModel());
		znackaTF.setText(auto.getZnacka());
		spzTF.setText(auto.getSpz());
	}
	
	private void notEditable(){
		idTF.setEditable(false);
		znackaTF.setEditable(false);
		modelTF.setEditable(false);
		spzTF.setEditable(false);
		priemernaSpotrebaTF.setEditable(false);
		stkPlatnostTF.setEditable(false);
		ekPlatnostTF.setEditable(false);
		vinTF.setEditable(false);
	}
	
	private void editable(){
		znackaTF.setEditable(true);
		modelTF.setEditable(true);
		spzTF.setEditable(true);
		priemernaSpotrebaTF.setEditable(true);
		stkPlatnostTF.setEditable(true);
		ekPlatnostTF.setEditable(true);
		vinTF.setEditable(true);
	}
}
