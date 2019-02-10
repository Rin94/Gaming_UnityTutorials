using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arreglo : MonoBehaviour {

	public GameObject[] objetosJuego;
	public int [] numeros = new int [10]{1,2,3,4,5,6,7,8,9,10};
	public List<int> nombres = new List<int>();
	public List<string> animales = new List<string>();


	// Use this for initialization
	void Start () {
		animales.Add ("Delfin");
		animales.Add ("Perro");
		animales.Add ("Gato");
		objetosJuego = new GameObject[10];

		foreach (int numero in numeros){
			Debug.Log ("El numero es: " + numero);
		}

		for (int i = 1; i <= 100; i++) {
			nombres.Add (i);
		}

		foreach (int numero in nombres) {
			Debug.Log (numero);
		}

		foreach (string an in animales) {
			Debug.Log (an);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
