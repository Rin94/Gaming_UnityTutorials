using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego : MonoBehaviour {

	public int puntuacionMaxima = 0;


	public static EstadoJuego estadoJuego;
	public  TextMesh max;
	
	private String rutaArchivo;

	void Awake(){
		rutaArchivo = Application.persistentDataPath + "/datos.dat";
		if(estadoJuego==null){
			estadoJuego = this;
			DontDestroyOnLoad(gameObject);
		}else if(estadoJuego!=this){
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		max.text = "Puntuacion Maxima";
		Cargar();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Cargar(){
		if(File.Exists(rutaArchivo)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(rutaArchivo, FileMode.Open);
			DatosAGuardar datos = (DatosAGuardar) bf.Deserialize(file);
			puntuacionMaxima = datos.puntuacionMaxima;
			max.text="Puntuacion Máxima: "+puntuacionMaxima;
			file.Close();
		}else{
			puntuacionMaxima = 0;
			max.text="Puntuacion Máxima: "+puntuacionMaxima;
			
		}
	}
}

