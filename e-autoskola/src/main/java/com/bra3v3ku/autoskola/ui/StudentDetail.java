package com.bra3v3ku.autoskola.ui;

import javax.swing.JPanel;
import java.awt.Dimension;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Font;
import javax.swing.JTextField;

public class StudentDetail extends JPanel {
	private JTextField idTF;
	private JTextField titulPredTF;
	private JTextField priezviskoTF;
	private JTextField rodnePriezviskoTF;
	private JTextField menoTF;
	private JTextField titulZaTF;
	private JTextField datumNarodeniaTF;
	private JTextField rodneCisloTF;
	private JTextField miestoNarodeniaTF;
	private JTextField ulicaTF;
	private JTextField ulicaCisloTF;
	private JTextField mestoTF;
	private JTextField pscTF;
	private JTextField telefonTF;
	private JTextField mobilTF;
	private JTextField emailTF;
	private JTextField cisloOpTF;
	private JTextField cisloVpTF;

	/**
	 * Create the panel.
	 */
	public StudentDetail() {
		setSize(new Dimension(800, 600));
		setLayout(null);
		
		JLabel idL = new JLabel("ID:");
		idL.setFont(new Font("Tahoma", Font.BOLD, 11));
		idL.setHorizontalAlignment(SwingConstants.RIGHT);
		idL.setBounds(203, 11, 46, 14);
		add(idL);
		
		JLabel titulPredL = new JLabel("Titul pred:");
		titulPredL.setFont(new Font("Tahoma", Font.BOLD, 11));
		titulPredL.setHorizontalAlignment(SwingConstants.RIGHT);
		titulPredL.setBounds(163, 36, 86, 14);
		add(titulPredL);
		
		JLabel priezviskoL = new JLabel("Priezvisko:");
		priezviskoL.setFont(new Font("Tahoma", Font.BOLD, 11));
		priezviskoL.setHorizontalAlignment(SwingConstants.RIGHT);
		priezviskoL.setBounds(203, 61, 46, 14);
		add(priezviskoL);
		
		JLabel rodnePriezviskoL = new JLabel("Rodn\u00E9 priezvisko:");
		rodnePriezviskoL.setFont(new Font("Tahoma", Font.BOLD, 11));
		rodnePriezviskoL.setHorizontalAlignment(SwingConstants.RIGHT);
		rodnePriezviskoL.setBounds(203, 86, 46, 14);
		add(rodnePriezviskoL);
		
		JLabel menoL = new JLabel("Meno:");
		menoL.setFont(new Font("Tahoma", Font.BOLD, 11));
		menoL.setHorizontalAlignment(SwingConstants.RIGHT);
		menoL.setBounds(203, 111, 46, 14);
		add(menoL);
		
		JLabel titulZaL = new JLabel("Titul za:");
		titulZaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		titulZaL.setHorizontalAlignment(SwingConstants.RIGHT);
		titulZaL.setBounds(203, 136, 46, 14);
		add(titulZaL);
		
		JLabel datumNarodeniaL = new JLabel("D\u00E1tum narodenia:");
		datumNarodeniaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		datumNarodeniaL.setHorizontalAlignment(SwingConstants.RIGHT);
		datumNarodeniaL.setBounds(203, 161, 46, 14);
		add(datumNarodeniaL);
		
		JLabel rodneCisloL = new JLabel("Rodn\u00E9 \u010D\u00EDslo:");
		rodneCisloL.setFont(new Font("Tahoma", Font.BOLD, 11));
		rodneCisloL.setHorizontalAlignment(SwingConstants.RIGHT);
		rodneCisloL.setBounds(203, 186, 46, 14);
		add(rodneCisloL);
		
		JLabel miestoNarodeniaL = new JLabel("Miesto narodenia:");
		miestoNarodeniaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		miestoNarodeniaL.setHorizontalAlignment(SwingConstants.RIGHT);
		miestoNarodeniaL.setBounds(203, 212, 46, 14);
		add(miestoNarodeniaL);
		
		JLabel ulicaL = new JLabel("Ulica:");
		ulicaL.setFont(new Font("Tahoma", Font.BOLD, 11));
		ulicaL.setHorizontalAlignment(SwingConstants.RIGHT);
		ulicaL.setBounds(203, 237, 46, 14);
		add(ulicaL);
		
		JLabel ulicaCisloL = new JLabel("Ulica \u010D\u00EDslo:");
		ulicaCisloL.setFont(new Font("Tahoma", Font.BOLD, 11));
		ulicaCisloL.setHorizontalAlignment(SwingConstants.RIGHT);
		ulicaCisloL.setBounds(203, 262, 46, 14);
		add(ulicaCisloL);
		
		JLabel mestoL = new JLabel("Mesto:");
		mestoL.setFont(new Font("Tahoma", Font.BOLD, 11));
		mestoL.setHorizontalAlignment(SwingConstants.RIGHT);
		mestoL.setBounds(203, 287, 46, 14);
		add(mestoL);
		
		JLabel pscL = new JLabel("PS\u010C:");
		pscL.setFont(new Font("Tahoma", Font.BOLD, 11));
		pscL.setHorizontalAlignment(SwingConstants.RIGHT);
		pscL.setBounds(203, 312, 46, 14);
		add(pscL);
		
		JLabel telefonL = new JLabel("Telef\u00F3n:");
		telefonL.setFont(new Font("Tahoma", Font.BOLD, 11));
		telefonL.setHorizontalAlignment(SwingConstants.RIGHT);
		telefonL.setBounds(203, 339, 46, 14);
		add(telefonL);
		
		JLabel mobilL = new JLabel("Mobil:");
		mobilL.setFont(new Font("Tahoma", Font.BOLD, 11));
		mobilL.setHorizontalAlignment(SwingConstants.RIGHT);
		mobilL.setBounds(203, 367, 46, 14);
		add(mobilL);
		
		JLabel emailL = new JLabel("Email:");
		emailL.setFont(new Font("Tahoma", Font.BOLD, 11));
		emailL.setHorizontalAlignment(SwingConstants.RIGHT);
		emailL.setBounds(203, 392, 46, 14);
		add(emailL);
		
		JLabel cisloOpL = new JLabel("\u010C\u00EDslo OP:");
		cisloOpL.setFont(new Font("Tahoma", Font.BOLD, 11));
		cisloOpL.setHorizontalAlignment(SwingConstants.RIGHT);
		cisloOpL.setBounds(203, 417, 46, 14);
		add(cisloOpL);
		
		JLabel cisloVpL = new JLabel("\u010C\u00EDslo VP:");
		cisloVpL.setFont(new Font("Tahoma", Font.BOLD, 11));
		cisloVpL.setHorizontalAlignment(SwingConstants.RIGHT);
		cisloVpL.setBounds(203, 442, 46, 14);
		add(cisloVpL);
		
		idTF = new JTextField();
		idTF.setBounds(314, 8, 86, 20);
		add(idTF);
		idTF.setColumns(10);
		
		titulPredTF = new JTextField();
		titulPredTF.setBounds(314, 33, 86, 20);
		add(titulPredTF);
		titulPredTF.setColumns(10);
		
		priezviskoTF = new JTextField();
		priezviskoTF.setBounds(314, 58, 86, 20);
		add(priezviskoTF);
		priezviskoTF.setColumns(10);
		
		rodnePriezviskoTF = new JTextField();
		rodnePriezviskoTF.setBounds(314, 83, 86, 20);
		add(rodnePriezviskoTF);
		rodnePriezviskoTF.setColumns(10);
		
		menoTF = new JTextField();
		menoTF.setBounds(314, 108, 86, 20);
		add(menoTF);
		menoTF.setColumns(10);
		
		titulZaTF = new JTextField();
		titulZaTF.setBounds(314, 133, 86, 20);
		add(titulZaTF);
		titulZaTF.setColumns(10);
		
		datumNarodeniaTF = new JTextField();
		datumNarodeniaTF.setBounds(314, 158, 86, 20);
		add(datumNarodeniaTF);
		datumNarodeniaTF.setColumns(10);
		
		rodneCisloTF = new JTextField();
		rodneCisloTF.setBounds(314, 183, 86, 20);
		add(rodneCisloTF);
		rodneCisloTF.setColumns(10);
		
		miestoNarodeniaTF = new JTextField();
		miestoNarodeniaTF.setBounds(314, 209, 86, 20);
		add(miestoNarodeniaTF);
		miestoNarodeniaTF.setColumns(10);
		
		ulicaTF = new JTextField();
		ulicaTF.setBounds(314, 234, 86, 20);
		add(ulicaTF);
		ulicaTF.setColumns(10);
		
		ulicaCisloTF = new JTextField();
		ulicaCisloTF.setBounds(314, 259, 86, 20);
		add(ulicaCisloTF);
		ulicaCisloTF.setColumns(10);
		
		mestoTF = new JTextField();
		mestoTF.setBounds(314, 284, 86, 20);
		add(mestoTF);
		mestoTF.setColumns(10);
		
		pscTF = new JTextField();
		pscTF.setBounds(314, 309, 86, 20);
		add(pscTF);
		pscTF.setColumns(10);
		
		telefonTF = new JTextField();
		telefonTF.setBounds(314, 336, 86, 20);
		add(telefonTF);
		telefonTF.setColumns(10);
		
		mobilTF = new JTextField();
		mobilTF.setBounds(314, 364, 86, 20);
		add(mobilTF);
		mobilTF.setColumns(10);
		
		emailTF = new JTextField();
		emailTF.setBounds(314, 389, 86, 20);
		add(emailTF);
		emailTF.setColumns(10);
		
		cisloOpTF = new JTextField();
		cisloOpTF.setBounds(314, 414, 86, 20);
		add(cisloOpTF);
		cisloOpTF.setColumns(10);
		
		cisloVpTF = new JTextField();
		cisloVpTF.setBounds(314, 439, 86, 20);
		add(cisloVpTF);
		cisloVpTF.setColumns(10);

	}

}
