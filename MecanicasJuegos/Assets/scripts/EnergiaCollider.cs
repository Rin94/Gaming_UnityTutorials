using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergiaCollider : MonoBehaviour {

	private AudioSource sonidito;
	private Jugador ot;
	private Transform t;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.GetComponent<Jugador> ()!= null) {
			sonidito = GetComponent<AudioSource> ();
			sonidito.Play();
			
		}

	}

	void OnTriggerStay(Collider other){
		ot=other.GetComponent<Jugador> ();
		t = ot.GetComponent<Transform> ();
		ot.puntuacion = ot.puntuacion + 1;
		t.localScale = new Vector3 (3, 3, 3);


		
		
	}

	void OnTriggerExit(Collider other){
		ot.puntuacion = 0;
		t.localScale = new Vector3 (1, 1, 1);
		Destroy (this.gameObject);
		
	}
}
