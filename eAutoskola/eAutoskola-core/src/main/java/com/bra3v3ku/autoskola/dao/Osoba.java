package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the osoba database table.
 * 
 */
@Entity
@Table(name="osoba")
public class Osoba implements Serializable {
	private static final long serialVersionUID = 1L;

	@EmbeddedId
	private OsobaPK id;

	private String cisloOp;

	private String cisloVp;

	private String datumNarodenia;

	private String email;

	private String meno;

	private String mesto;

	private String miestoNarodenia;

	private String mobil;

	private String priezvisko;

	private String psc;

	private String rodnePriezvisko;

	private String telefon;

	private String titulPred;

	private String titulZa;

	private String ulica;

	private String ulicaCislo;

    public Osoba() {
    }

	public OsobaPK getId() {
		return this.id;
	}

	public void setId(OsobaPK id) {
		this.id = id;
	}
	
	public String getCisloOp() {
		return this.cisloOp;
	}

	public void setCisloOp(String cisloOp) {
		this.cisloOp = cisloOp;
	}

	public String getCisloVp() {
		return this.cisloVp;
	}

	public void setCisloVp(String cisloVp) {
		this.cisloVp = cisloVp;
	}

	public String getDatumNarodenia() {
		return this.datumNarodenia;
	}

	public void setDatumNarodenia(String datumNarodenia) {
		this.datumNarodenia = datumNarodenia;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getMeno() {
		return this.meno;
	}

	public void setMeno(String meno) {
		this.meno = meno;
	}

	public String getMesto() {
		return this.mesto;
	}

	public void setMesto(String mesto) {
		this.mesto = mesto;
	}

	public String getMiestoNarodenia() {
		return this.miestoNarodenia;
	}

	public void setMiestoNarodenia(String miestoNarodenia) {
		this.miestoNarodenia = miestoNarodenia;
	}

	public String getMobil() {
		return this.mobil;
	}

	public void setMobil(String mobil) {
		this.mobil = mobil;
	}

	public String getPriezvisko() {
		return this.priezvisko;
	}

	public void setPriezvisko(String priezvisko) {
		this.priezvisko = priezvisko;
	}

	public String getPsc() {
		return this.psc;
	}

	public void setPsc(String psc) {
		this.psc = psc;
	}

	public String getRodnePriezvisko() {
		return this.rodnePriezvisko;
	}

	public void setRodnePriezvisko(String rodnePriezvisko) {
		this.rodnePriezvisko = rodnePriezvisko;
	}

	public String getTelefon() {
		return this.telefon;
	}

	public void setTelefon(String telefon) {
		this.telefon = telefon;
	}

	public String getTitulPred() {
		return this.titulPred;
	}

	public void setTitulPred(String titulPred) {
		this.titulPred = titulPred;
	}

	public String getTitulZa() {
		return this.titulZa;
	}

	public void setTitulZa(String titulZa) {
		this.titulZa = titulZa;
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

}