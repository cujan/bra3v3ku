package com.bra3v3ku.autoskola.dao;

import java.io.Serializable;
import javax.persistence.*;
import java.math.BigDecimal;
import java.util.Date;


/**
 * The persistent class for the automobil database table.
 * 
 */
@Entity
@Table(name="automobil")
public class Automobil implements Serializable {
	private static final long serialVersionUID = 1L;
	
	@GeneratedValue(strategy=GenerationType.SEQUENCE)
	@Id
	private int id;

    @Temporal( TemporalType.DATE)
	private Date emisnaPlatnost;

	private String model;

	private BigDecimal priemernaSpotreba;

	private String spz;

    @Temporal( TemporalType.DATE)
	private Date stkPlatnost;

	private String vin;

	private String znacka;

    public Automobil() {
    }

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Date getEmisnaPlatnost() {
		return this.emisnaPlatnost;
	}

	public void setEmisnaPlatnost(Date emisnaPlatnost) {
		this.emisnaPlatnost = emisnaPlatnost;
	}

	public String getModel() {
		return this.model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public BigDecimal getPriemernaSpotreba() {
		return this.priemernaSpotreba;
	}

	public void setPriemernaSpotreba(BigDecimal priemernaSpotreba) {
		this.priemernaSpotreba = priemernaSpotreba;
	}

	public String getSpz() {
		return this.spz;
	}

	public void setSpz(String spz) {
		this.spz = spz;
	}

	public Date getStkPlatnost() {
		return this.stkPlatnost;
	}

	public void setStkPlatnost(Date stkPlatnost) {
		this.stkPlatnost = stkPlatnost;
	}

	public String getVin() {
		return this.vin;
	}

	public void setVin(String vin) {
		this.vin = vin;
	}

	public String getZnacka() {
		return this.znacka;
	}

	public void setZnacka(String znacka) {
		this.znacka = znacka;
	}

}