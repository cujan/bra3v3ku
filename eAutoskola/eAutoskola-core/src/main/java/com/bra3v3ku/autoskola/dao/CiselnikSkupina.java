package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the ciselnik_skupina database table.
 * 
 */
@Entity
@Table(name="ciselnik_skupina")
public class CiselnikSkupina implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private String skupina;

    public CiselnikSkupina() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getSkupina() {
		return this.skupina;
	}

	public void setSkupina(String skupina) {
		this.skupina = skupina;
	}

}