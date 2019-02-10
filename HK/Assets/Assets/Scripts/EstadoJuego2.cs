using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego2 : MonoBehaviour {
	
	public int puntuacionMaxima = 0;
	public static EstadoJuego2 estadoJuego2;
	
	private String rutaArchivo;
	void Start () {

		Cargar();
	}
	
	void Awake(){
		rutaArchivo = Application.persistentDataPath + "/datos.dat";
		if(estadoJuego2==null){
			estadoJuego2 = this;
			DontDestroyOnLoad(gameObject);
		}else if(estadoJuego2!=this){
			Destroy(gameObject);
		}
	}
	public void Cargar(){
		if(File.Exists(rutaArchivo)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(rutaArchivo, FileMode.Open);
			DatosAGuardar datos = (DatosAGuardar) bf.Deserialize(file);
			puntuacionMaxima = datos.puntuacionMaxima;
			file.Close();
		}else{
			puntuacionMaxima = 0;
	
			
		}
	}
	
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Guardar(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(rutaArchivo);
		DatosAGuardar datos = new DatosAGuardar();
		datos.puntuacionMaxima = puntuacionMaxima;
		bf.Serialize(file, datos);
		file.Close();
	}
	

}

[Serializable]
class DatosAGuardar{
	public int puntuacionMaxima;
}
