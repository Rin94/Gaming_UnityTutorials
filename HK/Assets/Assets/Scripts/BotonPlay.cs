using UnityEngine;
using System.Collections;

public class BotonPlay : MonoBehaviour {

    //GameObject sonidoObj;
    //AudioSource sonido; 

    // Use this for initialization

    public static string nivel = "";
    public static bool dificultad = false;
	void Start () {
        //sonidoObj = GameObject.Find("Sonidos");
        //sonido = sonidoObj.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		Application.LoadLevel ("EscenaPreparacion");
	}

    public void AbrirEscena(){
        //sonido.Play();
        nivel = "nivel_1";
        dificultad = true;
        Application.LoadLevel("EscenaPreparacion");

    }

    public void AbrirEscenaFacil()
    {
        //sonido.Play();
        nivel = "nivel_1";
        dificultad = false;
        Application.LoadLevel("EscenaPreparacion");

    }

    public void AbrirSeleccionNiveles()
    {
        //sonido.Play();

        Application.LoadLevel("Seleccion");

    }

    public void AbrirEscena_2()
    {
        //sonido.Play();

        Application.LoadLevel("EscenaPreparacion");

    }

    public void AbrirRetro()
    {
        nivel = "nivel_retro";
        dificultad = true;
        Application.LoadLevel("EscenaPreparacion");
    }

    public void AbrirTiempo()
    {
        nivel = "nivel_tiempo";
        dificultad = true;
        Application.LoadLevel("EscenaPreparacion");
    }



    public void AbrirEspacio(){
        nivel = "nivel_2";
        dificultad = true;
        Application.LoadLevel("EscenaPreparacion");
    }


    public void AbrirMenu(){
        //sonido.Play();
        Application.LoadLevel("Title");

    }
}
