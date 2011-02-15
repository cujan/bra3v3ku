package com.bra3v3ku.autoskola.dao.generic;

import java.io.Serializable;
import java.util.List;

public interface BasicDao<T,ID extends Serializable> {
	T getEntityByID(Class<T> entityType,ID entityID);	
	List<T> getEntityList(Class<T> entityType);
	void insert(T entity);
	void update(T entity);
	void delete(T entity);
}
