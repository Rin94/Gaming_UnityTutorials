using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour {

	private AudioSource sonidito;
	private Jugador ot;
	private Transform t;

	void OnCollisionEnter(Collision other){
		if (other.collider.GetComponent<Jugador> ()!= null) {
			sonidito = GetComponent<AudioSource> ();
			sonidito.Play();

		}

	}

	void OnCollisionStay(Collision other){
		ot=other.collider.GetComponent<Jugador> ();
		t = ot.GetComponent<Transform> ();
		ot.puntuacion = ot.puntuacion + 1;
		t.localScale = new Vector3 (3, 3, 3);




	}

	void OnCollisionExit(Collision other){
		ot.puntuacion = 0;
		t.localScale = new Vector3 (1, 1, 1);
		Destroy (this.gameObject);

	}
}
