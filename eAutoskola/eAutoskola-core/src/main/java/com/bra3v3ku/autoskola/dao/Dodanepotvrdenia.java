package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;
import java.util.Date;


/**
 * The persistent class for the dodanepotvrdenia database table.
 * 
 */
@Entity
@Table(name="dodanepotvrdenia")
public class Dodanepotvrdenia implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private byte cervenyKriz;

	private int idKurz;

	private int idStudent;

    @Temporal( TemporalType.DATE)
	private Date zdraotnaPrehliadkaDatum;

	private byte zdravotnaPrehliadka;

    public Dodanepotvrdenia() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public byte getCervenyKriz() {
		return this.cervenyKriz;
	}

	public void setCervenyKriz(byte cervenyKriz) {
		this.cervenyKriz = cervenyKriz;
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

	public Date getZdraotnaPrehliadkaDatum() {
		return this.zdraotnaPrehliadkaDatum;
	}

	public void setZdraotnaPrehliadkaDatum(Date zdraotnaPrehliadkaDatum) {
		this.zdraotnaPrehliadkaDatum = zdraotnaPrehliadkaDatum;
	}

	public byte getZdravotnaPrehliadka() {
		return this.zdravotnaPrehliadka;
	}

	public void setZdravotnaPrehliadka(byte zdravotnaPrehliadka) {
		this.zdravotnaPrehliadka = zdravotnaPrehliadka;
	}

}