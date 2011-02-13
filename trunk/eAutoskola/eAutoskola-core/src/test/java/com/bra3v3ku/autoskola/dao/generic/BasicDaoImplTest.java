package com.bra3v3ku.autoskola.dao.generic;
import java.util.List;

import org.junit.Test;
import com.bra3v3ku.autoskola.dao.generic.BasicDao;
import com.bra3v3ku.autoskola.dao.Automobil;
import static org.junit.Assert.assertTrue;
import static org.junit.Assert.assertEquals;

public class BasicDaoImplTest {

	@Test
	public void testGetEntityByID() {
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>();
		Automobil auto  = autoDao.getEntityByID(new Automobil(),1);
		assertEquals(auto.getZnacka(), "Skoda");		
	}

	@Test
	public void testGetEntityList() {
		BasicDao<Automobil,Integer> autoDao = new BasicDaoImpl<Automobil, Integer>();
		List<Automobil> auto =  autoDao.getEntityList(new Automobil());
		assertTrue(auto.size()==4);			
	}
}
