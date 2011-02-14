package com.bra3v3ku.autoskola.dao.generic;

import java.io.Serializable;
import java.util.List;

public interface BasicDao<T,ID extends Serializable> {
	T getEntityByID(Object entityType,ID entityID);	
	List<T> getEntityList(Object entityType);
	void insert(T entity);
	void update(T entity);
	void delete(T entity);
}
