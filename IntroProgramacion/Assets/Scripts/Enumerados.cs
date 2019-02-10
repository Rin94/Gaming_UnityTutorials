using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerados : MonoBehaviour {

	public enum Brujula{ none, norte, sur, este, oeste};
	public Brujula miDirección= Brujula.norte;
	// Use this for initialization
	void Start () {
		 
		
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (miDirección);

		Debug.Log(invertirDireccion(miDirección));

		
	}

	public Brujula invertirDireccion(Brujula miDireccion){

		switch (miDireccion) {
		case Brujula.none:
			Debug.Log ("No se puede cambiar direccion");
			break;

		case Brujula.norte:
			miDireccion = Brujula.sur;
			break;
		case Brujula.sur:
			miDireccion = Brujula.norte;
			break;
		case Brujula.oeste:
			miDireccion = Brujula.este;
			break;
		case Brujula.este:
			miDireccion = Brujula.oeste;
			break;

		default:
			Debug.Log ("Hola");
			break;
		}

		return miDireccion;


	}
}
