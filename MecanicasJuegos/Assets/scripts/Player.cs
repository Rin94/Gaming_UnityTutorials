using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject paredGO;
	public Pared paredScript;


	// Use this for initialization
	void Start () {
		paredGO = GameObject.Find ("Pared");
		paredScript = paredGO.GetComponent<Pared> ();
		paredScript.paredActiva = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (paredScript.paredActiva) {
			Debug.Log ("Puedes entrar");
			paredGO.SetActive (true);


		} else {
			Debug.Log ("You shall no pass!!!");
			paredGO.SetActive (false);
		}
		
	}
}
