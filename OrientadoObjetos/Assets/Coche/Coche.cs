using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour {

	public string marca;
	public Ruedas cantidadRuedas;
	public Puertas cantidadPuertas;
	private bool encendido = false;

	public Coche(string marca, int cantidadRuedas, int cantidadPuertas){
		this.marca = marca;
		this.cantidadRuedas = new Ruedas (cantidadRuedas, 8, Ruedas.ColorRueda.azul, 8);
		this.cantidadPuertas = new Puertas( cantidadPuertas, false);

	}
		

	public bool EncenderMotor(){
		if (encendido == false) {
			encendido = true;
			Debug.Log ("Encendido: "+encendido);


		} else {
			Debug.Log ("El motor ya ésta encendido");
		}
		return encendido;
	}

	public bool ApagarMotor(){
		if (encendido) {
			encendido = false;
			Debug.Log ("Apagado: " + encendido);

		} else {
			Debug.Log ("El motor ya éstaba apagado");
		}
		return encendido;
	}

	public string toString(){
		return "Carro marca: " + marca +
		" numero de ruedas: " + cantidadRuedas.cantidad +
		" numero de puetas: " + cantidadPuertas.cantidad +
		" numero de tornillos " + cantidadRuedas.ll [0].cantidadTornillos;
	}

}
