package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;

/**
 * The primary key class for the osoba database table.
 * 
 */
@Embeddable
public class OsobaPK implements Serializable {
	//default serial version id, required for serializable classes.
	private static final long serialVersionUID = 1L;

	private int id;

	private String rodneCislo;

    public OsobaPK() {
    }
	public int getId() {
		return this.id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getRodneCislo() {
		return this.rodneCislo;
	}
	public void setRodneCislo(String rodneCislo) {
		this.rodneCislo = rodneCislo;
	}

	public boolean equals(Object other) {
		if (this == other) {
			return true;
		}
		if (!(other instanceof OsobaPK)) {
			return false;
		}
		OsobaPK castOther = (OsobaPK)other;
		return 
			(this.id == castOther.id)
			&& this.rodneCislo.equals(castOther.rodneCislo);

    }
    
	public int hashCode() {
		final int prime = 31;
		int hash = 17;
		hash = hash * prime + this.id;
		hash = hash * prime + this.rodneCislo.hashCode();
		
		return hash;
    }
}