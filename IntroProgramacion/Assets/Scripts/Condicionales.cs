using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour {

	public int velocidadCoche;
	private int velocidadMinima=40;
	private int velocidadAceptable=89;
	private int velocidadMaxima = 120;
	public bool encendido= false;

	// Use this for initialization
	void Start () {
		encendido = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(enceder_carro(encendido)==true){
			if (velocidadCoche > velocidadMaxima) {
				Debug.Log ("Se pasó la velocidad máxima");

			} else if (velocidadCoche < velocidadMinima) {
				Debug.Log ("Eres un lentillo dessu");

			} else if (velocidadCoche == 89) {
				Debug.Log ("Conduces kawaii desu");
			}

			else {
				Debug.Log ("Velocidad normal dessu");
			}
			
		}else{
			Debug.Log ("El carro no ésta encendido");
		}


		
	}

	protected bool enceder_carro(bool off){
		if (off) {
			return off;
			Debug.Log ("Encendido");

	
		}
		else{
			off = true;
			Debug.Log ("Se encendió");
			return off;
		}
	}
}
