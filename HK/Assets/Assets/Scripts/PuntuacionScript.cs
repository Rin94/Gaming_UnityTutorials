using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuntuacionScript : MonoBehaviour {
	
	private int puntuacion = 0;
	public static int puntuacionObtenida;
	public static int valorMaximo;
	public Text Marcador;
	bool cambio=false;



    // Use this for initialization
    public void Start () {
        //audioBueno = audioBuenoObject.GetComponent<AudioSource>();
        puntuacionObtenida =0;
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

        ActualizarMarcador();

	}


    public void IncrementarPuntos(Notification notificacion){
		if (Application.loadedLevelName == "Nivel2"&&cambio==true) {
			//Debug.Log ("Pa");
			puntuacion=valorMaximo;
			cambio=false;
			ActualizarMarcador();
		}
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion+=puntosAIncrementar;

        ActualizarMarcador();
	}
	
	public void ActualizarMarcador(){
		Marcador.text = puntuacion.ToString();
	}

	void PersonajeHaMuerto(Notification notificacion){
		puntuacionObtenida = puntuacion;
		valorMaximo = EstadoJuego2.estadoJuego2.puntuacionMaxima;
		if(puntuacion > valorMaximo){
			EstadoJuego2.estadoJuego2.puntuacionMaxima = puntuacion;
			EstadoJuego2.estadoJuego2.Guardar();
		}
	}
	
	// Update is called once per frame
	public void Update () {

        if (Marcador.text == "2500"&& Application.loadedLevelName=="Nivel1") {
			cambio=true;
			Application.LoadLevel("Nivel2");

		}
	
		
	}
}
