package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the vseobecneudaje database table.
 * 
 */
@Entity
@Table(name="vseobecneudaje")
public class Vseobecneudaje implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private String dic;

	private String email;

	private String ico;

	private String mesto;

	private String mobil;

	private String nazovOrganizacie;

	private String psc;

	private String telefon;

	private String ulica;

	private String ulicaCislo;

	private String www;

    public Vseobecneudaje() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getDic() {
		return this.dic;
	}

	public void setDic(String dic) {
		this.dic = dic;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getIco() {
		return this.ico;
	}

	public void setIco(String ico) {
		this.ico = ico;
	}

	public String getMesto() {
		return this.mesto;
	}

	public void setMesto(String mesto) {
		this.mesto = mesto;
	}

	public String getMobil() {
		return this.mobil;
	}

	public void setMobil(String mobil) {
		this.mobil = mobil;
	}

	public String getNazovOrganizacie() {
		return this.nazovOrganizacie;
	}

	public void setNazovOrganizacie(String nazovOrganizacie) {
		this.nazovOrganizacie = nazovOrganizacie;
	}

	public String getPsc() {
		return this.psc;
	}

	public void setPsc(String psc) {
		this.psc = psc;
	}

	public String getTelefon() {
		return this.telefon;
	}

	public void setTelefon(String telefon) {
		this.telefon = telefon;
	}

	public String getUlica() {
		return this.ulica;
	}

	public void setUlica(String ulica) {
		this.ulica = ulica;
	}

	public String getUlicaCislo() {
		return this.ulicaCislo;
	}

	public void setUlicaCislo(String ulicaCislo) {
		this.ulicaCislo = ulicaCislo;
	}

	public String getWww() {
		return this.www;
	}

	public void setWww(String www) {
		this.www = www;
	}

}