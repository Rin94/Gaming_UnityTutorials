using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

	public int puntuacion=0;
	public float velocidad = 5;

	private Transform t;

	// Use this for initialization
	void Start () {
		t = GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("left")) {
			t.Translate (Vector3.left * velocidad * Time.deltaTime);

			
		} else if (Input.GetButton ("right")) {
			t.Translate (Vector3.right * velocidad * Time.deltaTime);
			
		} else if (Input.GetButton ("up")) {
			t.Translate (Vector3.forward * velocidad * Time.deltaTime);

		} else if (Input.GetButton ("down")) {
			t.Translate (Vector3.back * velocidad * Time.deltaTime);

		}
		
	}
}
