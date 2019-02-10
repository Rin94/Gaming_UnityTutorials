using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica1 : MonoBehaviour {

	//public GameObject cubo;//No hace falta hacer esto porque accedemos desde el ide
	public GameObject miCamara;
	public GameObject buscaObjeto;
	public GameObject[] cubos;

	// Use this for initialization
	void Start () {
		print(gameObject.name);
		Debug.Log(miCamara.name);
		print (gameObject.transform.position);
		buscaObjeto = GameObject.Find ("Sphere");
		cubos = GameObject.FindGameObjectsWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
