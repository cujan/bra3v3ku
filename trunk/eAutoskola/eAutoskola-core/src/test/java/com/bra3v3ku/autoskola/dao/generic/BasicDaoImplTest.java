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
	public void testInsert() {
		Automobil auto= new Automobil();
		auto.setModel("polo");
		auto.setZnacka("vw1");
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>(PERSISTENCE_UNIT_NAME);
		autoDao.insert(auto);
		List<Automobil> auto1 =  autoDao.getEntityList(Automobil.class);
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
		auto = autoDao.getEntityByID(Automobil.class, 0);
		auto.setZnacka(auto.getZnacka()+"_updated");
		autoDao.update(auto);
		List<Automobil> auto1 =  autoDao.getEntityList(Automobil.class);
		for (Automobil a: auto1){
			if (a.getModel().contains("_updated")){
				assertTrue(true);
			}
		}
	}
	
	
	@Test
	public void testGetEntityByID() {
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>( PERSISTENCE_UNIT_NAME );
		Automobil auto  = autoDao.getEntityByID(Automobil.class,0);
		assertEquals(auto.getZnacka(), "Skoda");		
	}

	@Test
	public void testGetEntityList() {
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>( PERSISTENCE_UNIT_NAME );
		List<Automobil> auto =  autoDao.getEntityList(Automobil.class);
		for (Automobil a : auto){
			System.out.println("ID: "+a.getId()+" Znacka: "+a.getZnacka()+ " Model:" + a.getModel() );			
		}
		assertTrue(auto.size()>0);			
	}


	@Test
	public void testDelete() {
		Automobil auto= new Automobil();
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>(PERSISTENCE_UNIT_NAME);
		Automobil a1= autoDao.getEntityByID(Automobil.class,0);;
		auto = autoDao.getEntityByID(Automobil.class,0 );
		autoDao.delete(auto);
		List<Automobil> auto1 =  autoDao.getEntityList(Automobil.class);
		Boolean isIncluded=false;
		for (Automobil a: auto1){
			if (a.getZnacka()==a1.getZnacka()){
				isIncluded=true;
			}
		}
		assertTrue(!isIncluded);
	}

	
	
}
