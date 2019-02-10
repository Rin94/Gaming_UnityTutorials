using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour {

	public MotorPrincipal motorCarretera;
	public GameObject mCarreteraGO;
	public float tiempo;
	public float distancia;
	public Text textDistancia;
	public Text textCronometro;


	// Use this for initialization
	void Start () {
		mCarreteraGO = GameObject.Find ("MotorCarreteras");
		motorCarretera = mCarreteraGO.GetComponent<MotorPrincipal> ();

		//No olvidar al buscar objetos, primero se busca el gameObject y luego su script

		//motorCarretera= GetComponent<MotorPrincipal>();
		//mCarreteraGO = motorCarretera.gameObject;
		textDistancia.text="0";
		textCronometro.text = "02:00";

		tiempo = 120;
		distancia = 0;

		
	}
	
	// Update is called once per frame
	void Update () {
		if (motorCarretera.inicioJuego && motorCarretera.juegoTerminado==false) {
			CalculoTiempoDistancia ();
			CalculoTiempo ();
		}

		
	}

	void CalculoTiempoDistancia(){
		distancia += Time.deltaTime * motorCarretera.velociad;
		textDistancia.text = ((int)distancia).ToString ();

	}

	void CalculoTiempo(){
		if (tiempo >= 0) {
			tiempo -= Time.deltaTime;
			int minutos = (int)tiempo / 60;
			int segundos = (int)tiempo % 60;
			textCronometro.text =
				minutos.ToString ().PadLeft(2,'0') + ":" + segundos.ToString ().PadLeft (2, '0');
		}
		else if (tiempo <0) {
			motorCarretera.juegoTerminado = true;
			motorCarretera.FinJuego ();
		}
		
	}


}
