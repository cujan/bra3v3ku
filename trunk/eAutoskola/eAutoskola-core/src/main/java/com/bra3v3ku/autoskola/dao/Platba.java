package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the platba database table.
 * 
 */
@Entity
@Table(name="platba")
public class Platba implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private int idKurz;

	private int idStudent;

	private byte kolokOpravny1;

	private byte kolokOpravny2;

	private byte kolokRiadnyTermin;

	private double platbaZaKurz;

    public Platba() {
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

	public byte getKolokOpravny1() {
		return this.kolokOpravny1;
	}

	public void setKolokOpravny1(byte kolokOpravny1) {
		this.kolokOpravny1 = kolokOpravny1;
	}

	public byte getKolokOpravny2() {
		return this.kolokOpravny2;
	}

	public void setKolokOpravny2(byte kolokOpravny2) {
		this.kolokOpravny2 = kolokOpravny2;
	}

	public byte getKolokRiadnyTermin() {
		return this.kolokRiadnyTermin;
	}

	public void setKolokRiadnyTermin(byte kolokRiadnyTermin) {
		this.kolokRiadnyTermin = kolokRiadnyTermin;
	}

	public double getPlatbaZaKurz() {
		return this.platbaZaKurz;
	}

	public void setPlatbaZaKurz(double platbaZaKurz) {
		this.platbaZaKurz = platbaZaKurz;
	}

}