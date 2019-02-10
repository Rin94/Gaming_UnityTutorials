using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carretera : MonoBehaviour {

	List <Coche> coches = new List <Coche>();


	// Use this for initialization
	void Start () {
		Coche carro = new Coche ("Nissan ma",4,4);
		carro.ApagarMotor ();
		coches.Add (carro);
		carro.EncenderMotor ();
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Coche c in coches){
			Debug.Log (c.toString ());
			
		}
		
	}
}
