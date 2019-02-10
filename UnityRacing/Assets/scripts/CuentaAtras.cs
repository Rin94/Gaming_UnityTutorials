using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour {

	public float tiempo;
	private AudioSource pep;
	public GameObject hijo;
	private AudioSource go;
	private SpriteRenderer numeros;
	public Sprite []contador;

	public GameObject motorGO;
	public MotorPrincipal motorScript;

	public GameObject controladorCoche;
	public Coche cocheScript;



	// Use this for initialization
	public void Start () {
		
		InicioComponentes ();
		StartCoroutine(Contador ());
		

		
	}

	public void InicioComponentes(){
		motorGO = GameObject.Find ("MotorCarreteras");
		motorScript = motorGO.GetComponent<MotorPrincipal> ();

		numeros = this.GetComponentInChildren<SpriteRenderer> ();
		hijo = GameObject.Find ("Contador");

		controladorCoche = GameObject.Find ("ControladorCoche");
//		cocheScript = controladorCoche.GetComponentInChildren<Coche> ();

		cocheScript = GetComponent<Coche> ();
		go = hijo.GetComponent<AudioSource> ();
		pep = GetComponent<AudioSource> ();
		

	}
	
	// Update is called once per frame
	//public void Update () {
		//if ((int)tiempo > 0) {
			//contarTiempo ();
		//}
	//}

	IEnumerator Contador(){

		yield return new WaitForSeconds(1.0f);
		controladorCoche.GetComponent<AudioSource> ().Play();
		pep.Play();
		numeros.sprite = contador [3];

		yield return new WaitForSeconds(1.0f);
		pep.Play();
		numeros.sprite = contador [2];

		yield return new WaitForSeconds(1.0f);
		pep.Play();
		numeros.sprite = contador [1];

		yield return new WaitForSeconds(1.0f);
		go.Play();
		numeros.sprite = contador [0];
	

		yield return new WaitForSeconds(2.0f);
		numeros.sprite = null;
		motorScript.inicioJuego = true;
		motorScript.velociad = 10;



	}



}
