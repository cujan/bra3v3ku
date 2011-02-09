package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the studentskupinavlastnik database table.
 * 
 */
@Entity
@Table(name="studentskupinavlastnik")
public class Studentskupinavlastnik implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private int idCiselnikSkupina;

	private int idStudent;

    public Studentskupinavlastnik() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getIdCiselnikSkupina() {
		return this.idCiselnikSkupina;
	}

	public void setIdCiselnikSkupina(int idCiselnikSkupina) {
		this.idCiselnikSkupina = idCiselnikSkupina;
	}

	public int getIdStudent() {
		return this.idStudent;
	}

	public void setIdStudent(int idStudent) {
		this.idStudent = idStudent;
	}

}