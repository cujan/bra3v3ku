package com.bra3v3ku.autoskola.ui;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTable;
import com.bra3v3ku.autoskola.dao.Automobil;
import com.bra3v3ku.autoskola.ui.AutomobilDetail;
import com.bra3v3ku.autoskola.dao.generic.BasicDao;
import com.bra3v3ku.autoskola.dao.generic.BasicDaoImpl;
import org.jdesktop.swingbinding.JTableBinding;
import org.jdesktop.swingbinding.SwingBindings;
import org.jdesktop.beansbinding.AutoBinding.UpdateStrategy;
import org.jdesktop.beansbinding.BeanProperty;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class ZoznamAutomobil extends JFrame {
	private static final String PERSISTENCE_UNIT_NAME = "eAutoskolaDerby";
	private JPanel contentPane;
	private JTable table;
	private BasicDao<Automobil, Integer> autoDao= new BasicDaoImpl<Automobil,Integer>(PERSISTENCE_UNIT_NAME);
	private List<Automobil> auta = autoDao.getEntityList(Automobil.class);

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					
					ZoznamAutomobil frame = new ZoznamAutomobil();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public ZoznamAutomobil() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				if (e.getClickCount()==2){
					AutomobilDetail.main((Integer)table.getValueAt(table.getSelectedRow(), 0));
				}
			}
		});
		table.setBounds(30, 45, 389, 208);
		contentPane.add(table);
		
		JButton insertBtn = new JButton("Novy zaznam");
		insertBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				AutomobilDetail.main(-1);				
			}
		});
		insertBtn.setBounds(89, 11, 117, 23);
		contentPane.add(insertBtn);
		initDataBindings();
	}
	protected void initDataBindings() {
		JTableBinding<Automobil, List<Automobil>, JTable> jTableBinding = SwingBindings.createJTableBinding(UpdateStrategy.READ, auta, table);
		//
		BeanProperty<Automobil, Integer> automobilBeanProperty = BeanProperty.create("id");
		jTableBinding.addColumnBinding(automobilBeanProperty).setColumnName("ID").setEditable(false);
		//
		BeanProperty<Automobil, String> automobilBeanProperty_1 = BeanProperty.create("znacka");
		jTableBinding.addColumnBinding(automobilBeanProperty_1).setColumnName("Znacka").setEditable(false);
		//
		BeanProperty<Automobil, String> automobilBeanProperty_2 = BeanProperty.create("model");
		jTableBinding.addColumnBinding(automobilBeanProperty_2).setColumnName("Model").setEditable(false);
		//
		BeanProperty<Automobil, String> automobilBeanProperty_3 = BeanProperty.create("spz");
		jTableBinding.addColumnBinding(automobilBeanProperty_3).setColumnName("SPZ").setEditable(false);
		//
		jTableBinding.bind();
	}
}
