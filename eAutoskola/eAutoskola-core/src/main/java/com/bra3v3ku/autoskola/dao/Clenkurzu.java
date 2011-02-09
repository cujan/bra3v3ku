package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the clenkurzu database table.
 * 
 */
@Entity
@Table(name="clenkurzu")
public class Clenkurzu implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private int idKurz;

	private int idStudent;

    public Clenkurzu() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getIdKurz() {
		return this.idKurz;
	}

	public void setIdKurz(int idKurz) {
		this.idKurz = idKurz;
	}

	public int getIdStudent() {
		return this.idStudent;
	}

	public void setIdStudent(int idStudent) {
		this.idStudent = idStudent;
	}

}