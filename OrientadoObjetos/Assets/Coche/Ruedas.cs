using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruedas : MonoBehaviour {

	public int cantidad;
	public int grosor;
	public llantas [] ll;

	public enum ColorRueda{azul, negra, roja, verde}
	public ColorRueda colorRueda;

	public  Ruedas(int cantidad, int grosor, ColorRueda colorRueda, int tornillos){
		this.cantidad = cantidad;
		this.grosor = grosor;
		this.colorRueda = colorRueda;
		ll = new llantas[cantidad];
		for (int c=0; c< cantidad;c++) {
			 ll[0]= new llantas (tornillos);
		}
		
	}

}
