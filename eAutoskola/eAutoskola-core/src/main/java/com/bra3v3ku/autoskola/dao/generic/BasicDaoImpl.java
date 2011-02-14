package com.bra3v3ku.autoskola.dao.generic;

import java.io.Serializable;
import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;


public class BasicDaoImpl<T, ID extends Serializable> implements BasicDao<T, ID> {
	private static EntityManagerFactory factory;

	public T getEntityByID(Object entityType,ID entityID) {
		EntityManager em = factory.createEntityManager();
		return (T)em.find(entityType.getClass(), entityID);
	}

	public BasicDaoImpl(String persistenceUnitName) {
		super();
		factory = Persistence.createEntityManagerFactory(persistenceUnitName);
	}

	public List<T> getEntityList(Object entityType) {
		EntityManager em = factory.createEntityManager();
		Query q = em.createQuery("select t from "+entityType.getClass().getSimpleName()+" t");
		List<T> entity = q.getResultList();
		em.close();
		return entity;
	}
}
