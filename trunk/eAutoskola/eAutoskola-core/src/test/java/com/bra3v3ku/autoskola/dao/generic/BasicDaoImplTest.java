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
		assertTrue(auto.size()==4);			
	}
}
