using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnObjeto : MonoBehaviour {

	public Pared [] arregloDePared;


	// Use this for initialization
	void Start () {

		arregloDePared = Object.FindObjectsOfType(typeof(Pared)) as Pared[];
		Debug.Log (arregloDePared.Length);
		Debug.Log (arregloDePared.ToString());
		foreach (Pared p in arregloDePared) {
			p.paredActiva = false;
		}


		
	}
	

}
