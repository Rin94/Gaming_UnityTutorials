using UnityEngine;
using System.Collections;

public class MaximaScript : MonoBehaviour {

	// Use this for initialization
	public TextMesh max;
	void Start () {
		//EstadoJuego2.estadoJuego2.puntuacionMaxima;
		max.text ="Puntuacion Maxima"+ PuntuacionScript.valorMaximo;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
