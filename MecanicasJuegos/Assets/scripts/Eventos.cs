using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour {
	public GameObject gm;

	// Use this for initialization
	void Start () {
		Debug.Log ("Iniciando juego");
		
	}
	
	// Update is called once per frame
	void Update () {
		print ("Cada 60 frames");
		
	}

	void Awake(){
		print ("Espera....");
		
	}

	//Activo
	void OnDisable(){
		print ("El cubo no ésta activo");
	}

	void OnEnable(){
		print ("El cubo ésta activo :D");
		
	}

	void OnMouseEnter(){
		Debug.Log (gm.gameObject.transform.localScale);
		
	}

	void OnMouseExit(){
		Debug.Log ("Me fui :)");

	}

	void OnMouseOver(){
		Debug.Log ("Hola");
	}

	void OnMouseDown(){
		Debug.Log ("Ke hace");
	}
}
