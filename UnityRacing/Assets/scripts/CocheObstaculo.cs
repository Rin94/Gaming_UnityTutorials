using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocheObstaculo : MonoBehaviour {
	Coche azul;
	public Text vidas;

	public GameObject audioGO;
	public AudioFX clip;
	public GameObject cronometroGo;
	public Cronometro cronometroScript;
	public GameObject motorGO;
	public MotorPrincipal motorScript;

	void Start(){
		audioGO = GameObject.Find ("AudioFX");
		clip = audioGO.GetComponent<AudioFX> ();
		cronometroGo = GameObject.FindObjectOfType<Cronometro> ().gameObject;
		cronometroScript = cronometroGo.GetComponent<Cronometro> ();
		motorGO = GameObject.Find ("MotorCarreteras");
		motorScript = motorGO.GetComponent<MotorPrincipal> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.GetComponent<Coche> () != null) {
			azul = other.GetComponent<Coche> ();
			azul.life = azul.life - 1;
			cronometroScript.tiempo = cronometroScript.tiempo - 20;

			vidas.text = azul.life.ToString ();
			if (azul.life <= 0) {
				Destroy (azul.gameObject);
				motorScript.juegoTerminado = true;
				motorScript.FinJuego ();
			}
			clip.cocheSonidoChoque ();
			Destroy (this.gameObject);

		}
	}

}


