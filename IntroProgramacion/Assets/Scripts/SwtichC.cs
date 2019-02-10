using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtichC : MonoBehaviour {

	public int vidas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		switch (vidas) {
		case 0:
			Debug.Log ("Game Over, tienes: " + vidas + " vidas");
			break;

		case 99:
			Debug.Log ("Tienes el número de vidas máximo, no puedes tener más");
			break;

		default:
			Debug.Log ("Tienes: " + vidas + " vidas");
			break;

		}
		
	}
}
