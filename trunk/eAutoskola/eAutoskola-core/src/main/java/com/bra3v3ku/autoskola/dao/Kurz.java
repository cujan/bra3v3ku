package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;
import java.util.Date;


/**
 * The persistent class for the kurz database table.
 * 
 */
@Entity
@Table(name="kurz")
public class Kurz implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private String denVykonavania;

	private String hodinaVykonavania;

	private int idInstruktor;

	private String skupiny;

    @Temporal( TemporalType.DATE)
	private Date zaciatokDatum;

    public Kurz() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getDenVykonavania() {
		return this.denVykonavania;
	}

	public void setDenVykonavania(String denVykonavania) {
		this.denVykonavania = denVykonavania;
	}

	public String getHodinaVykonavania() {
		return this.hodinaVykonavania;
	}

	public void setHodinaVykonavania(String hodinaVykonavania) {
		this.hodinaVykonavania = hodinaVykonavania;
	}

	public int getIdInstruktor() {
		return this.idInstruktor;
	}

	public void setIdInstruktor(int idInstruktor) {
		this.idInstruktor = idInstruktor;
	}

	public String getSkupiny() {
		return this.skupiny;
	}

	public void setSkupiny(String skupiny) {
		this.skupiny = skupiny;
	}

	public Date getZaciatokDatum() {
		return this.zaciatokDatum;
	}

	public void setZaciatokDatum(Date zaciatokDatum) {
		this.zaciatokDatum = zaciatokDatum;
	}

}