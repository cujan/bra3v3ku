package com.bra3v3ku.autoskola.dao.generic;
import java.util.List;

import org.junit.Test;
import com.bra3v3ku.autoskola.dao.generic.BasicDao;
import com.bra3v3ku.autoskola.dao.Automobil;
import static org.junit.Assert.assertTrue;
import static org.junit.Assert.assertEquals;

public class BasicDaoImplTest {
	
	private static final String PERSISTENCE_UNIT_NAME = "eAutoskolaDerby"; 
	
	@Test
	public void testGetEntityByID() {
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>( PERSISTENCE_UNIT_NAME );
		Automobil auto  = autoDao.getEntityByID(new Automobil(),1);
		assertEquals(auto.getZnacka(), "Skoda");		
	}

	@Test
	public void testGetEntityList() {
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>( PERSISTENCE_UNIT_NAME );
		List<Automobil> auto =  autoDao.getEntityList(new Automobil());
		for (Automobil a : auto){
			System.out.println("ID: "+a.getId()+" Znacka: "+a.getZnacka()+ " Model:" + a.getModel() );			
		}
		assertTrue(auto.size()==4);			
	}
	
	@Test
	public void testInsert() {
		Automobil auto= new Automobil();
		auto.setModel("polo");
		auto.setZnacka("vw");
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>(PERSISTENCE_UNIT_NAME);
		autoDao.insert(auto);
		List<Automobil> auto1 =  autoDao.getEntityList(new Automobil());
		for (Automobil a: auto1){
			if (a.getZnacka()=="vw"){
				assertTrue(true);
			}
		}
	}

	@Test
	public void testUpdate() {
		Automobil auto= new Automobil();
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>(PERSISTENCE_UNIT_NAME);
		auto = autoDao.getEntityByID(new Automobil(), 5);
		auto.setZnacka("polo1");
		autoDao.update(auto);
		List<Automobil> auto1 =  autoDao.getEntityList(new Automobil());
		for (Automobil a: auto1){
			if (a.getModel()=="polo1"){
				assertTrue(true);
			}
		}
	}

	@Test
	public void testDelete() {
		Automobil auto= new Automobil();
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>(PERSISTENCE_UNIT_NAME);
		auto = autoDao.getEntityByID(new Automobil(), 6);
		autoDao.delete(auto);
		List<Automobil> auto1 =  autoDao.getEntityList(new Automobil());
		Boolean isIncluded=false;
		for (Automobil a: auto1){
			if (a.getZnacka()=="vw"){
				isIncluded=true;
			}
		}
		assertTrue(!isIncluded);
	}

	
	
}
