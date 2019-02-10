using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotorPrincipal : MonoBehaviour {

	public float velociad;
	public bool inicioJuego;
	public bool juegoTerminado;
	private GameObject contenedorCarreteras;
	public GameObject[] arregloContenedor;
	public List <GameObject> listaCalle = new List<GameObject>();
	int contadorCalles=0;
	int selectorCalles;
	public float tamañoCalle=0;
	int K=0;

	public GameObject calleAnterior;
	public GameObject calleNueva;
	public Vector3 medidaLimitePantalla;
	public bool salioPantalla;
	public Camera camaraGO;//Para encontrar por componentes
	public GameObject obCamara; //referencia de la camara
	// Use this for initialization
	//
	public GameObject cuentaGO;
	public CuentaAtras cuentaAtras;
	//--------
	public Coche cocheScript;
	public GameObject cocheGO;
	public GameObject audioFXGO;
	public AudioFX audioFXScript;
	public GameObject bgFinalGO;
	public Text txtDistancia;

	void Start () {
		cuentaGO = GameObject.Find ("CuentaAtras");
		cuentaAtras = cuentaGO.GetComponent<CuentaAtras> ();
		//cuentaAtras.Start();
		InicioJuego ();
	}

	void CrearCalles(){
		contadorCalles++;
		selectorCalles = Random.Range (0, arregloContenedor.Length);
		GameObject calle = Instantiate (arregloContenedor [selectorCalles]);
		calle.SetActive (true);
		calle.name = "Calles" + contadorCalles;
		calle.transform.parent = gameObject.transform;
		PosicionoCalle ();



	}

	void InicioJuego(){
		obCamara = GameObject.Find ("MainCamera");
		camaraGO = obCamara.GetComponent<Camera> ();
		//Debug.Log (camaraGO.name);
		contenedorCarreteras = GameObject.Find ("ContenedorCalles");


		cocheGO = GameObject.FindObjectOfType<Coche> ().gameObject;
		cocheScript = cocheGO.GetComponent<Coche> ();

		audioFXGO = GameObject.Find("AudioFX").gameObject;
		audioFXScript = audioFXGO.GetComponent<AudioFX> ();

		bgFinalGO = GameObject.Find ("Panel");
		bgFinalGO.SetActive (false);

		BuscaCarreteras ();
		VelocidadMotorCarreta ();
		MedirPantalla ();


		

	}
	void PosicionoCalle(){
		calleAnterior = GameObject.Find ("Calles" + (contadorCalles - 1));
		calleNueva = GameObject.Find ("Calles" + contadorCalles);
		MidoCalle ();
		calleNueva.transform.position = new Vector3
			(calleAnterior.transform.position.x, 
				calleAnterior.transform.position.y+tamañoCalle,
				0);
		salioPantalla = false;
	}

	void MidoCalle(){
		for (int i = 0; i < calleAnterior.transform.childCount; i++) {
			if(calleAnterior.transform.GetChild(i).gameObject.GetComponent<Piezas>()!=null){
				float tamañoPieza= calleAnterior.transform.GetChild (i).gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
				tamañoCalle = tamañoCalle+ tamañoPieza;
			}
		}
		Debug.Log (tamañoCalle);

	}

	void VelocidadMotorCarreta(){
		velociad = 10;
	}

	void MedirPantalla(){
		medidaLimitePantalla = new Vector3 (0, camaraGO.ScreenToWorldPoint (new Vector3 (0, 0, 0)).y - 0.5f, 0);
	}

	void BuscaCarreteras(){
		arregloContenedor = GameObject.FindGameObjectsWithTag ("Calle");
		int i = 0;
		foreach (GameObject a in arregloContenedor) {
			listaCalle.Add (a);
			a.gameObject.transform.parent = contenedorCarreteras.transform;
			a.gameObject.SetActive (false);
			a.gameObject.name = "CalleOFF_" + i;
			i++;
		}
		CrearCalles ();

	}
	
	// Update is called once per frame
	void Update () {
		if (inicioJuego == true && juegoTerminado == false && cocheScript.life>0) {
			transform.Translate (Vector3.down * velociad * Time.deltaTime);

			if (calleAnterior.transform.position.y + tamañoCalle < medidaLimitePantalla.y && salioPantalla == false) {
				salioPantalla = true;
				DestruyoCalles ();
			}

		} else {
			velociad = 0;
			if (juegoTerminado == true && K==0) {
				K=1;
				FinJuego ();
			}



		}

		
	}

	public void FinJuego(){
		Debug.Log ("Hola");
		bgFinalGO.SetActive (true);
		Cronometro cr = GameObject.Find ("Cronometro").GetComponent<Cronometro> ();
		txtDistancia.text = ((int)cr.distancia).ToString() + " MTS";
		audioFXScript.fxMusic ();


	}

	void DestruyoCalles(){
		Destroy (calleAnterior);
		tamañoCalle = 0;
		calleAnterior = null;
		CrearCalles ();

	}
}
