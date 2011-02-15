package com.bra3v3ku.autoskola.dao.generic;

import java.io.Serializable;
import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;


public class BasicDaoImpl<T, ID extends Serializable> implements BasicDao<T, ID> {
	private static EntityManagerFactory factory;

	@SuppressWarnings("unchecked")
	public T getEntityByID(Class<T> entityType,ID entityID) {
		EntityManager em = factory.createEntityManager();
		Object ent = em.find(entityType, entityID);
		em.close();
		return (T)ent;
	}

	public BasicDaoImpl(String persistenceUnitName) {
		super();
		factory = Persistence.createEntityManagerFactory(persistenceUnitName);
	}

	@SuppressWarnings("unchecked")
	public List<T> getEntityList(Class<T> entityType) {
		EntityManager em = factory.createEntityManager();
		Query q = em.createQuery("select t from "+entityType.getSimpleName()+" t");
		List<T> entity = q.getResultList();
		em.close();
		return entity;
	}

	@Override
	public void insert(T entity) {
		EntityManager em = factory.createEntityManager();
		em.getTransaction().begin();
		em.persist(entity);
		em.getTransaction().commit();
		em.close();		
	}
	
	public void update(T entity) {
	EntityManager em = factory.createEntityManager();
	em.getTransaction().begin();
	em.merge(entity);
	em.getTransaction().commit();
	em.close();	
	}

	public void delete(T entity) {
		EntityManager em = factory.createEntityManager();
		em.getTransaction().begin();
		em.remove(entity);
		em.getTransaction().commit();
		em.close();		
	}
}
