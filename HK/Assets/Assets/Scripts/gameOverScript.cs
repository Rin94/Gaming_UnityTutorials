using UnityEngine;
using System.Collections;
using TMPro;

public class gameOverScript : MonoBehaviour {
    //public TextMesh puntuacion;
    //public TextMesh max;

    public GameObject puntuacionObj;
    public GameObject maxObj;
    TextMeshProUGUI puntuacion;
    TextMeshProUGUI max;

    // Use this for initialization
    void Start () {

        puntuacion = puntuacionObj.GetComponent<TextMeshProUGUI>();
        max = maxObj.GetComponent<TextMeshProUGUI>();
    
        if(System.Convert.ToInt32(PuntuacionScript.puntuacionObtenida)> 
           System.Convert.ToInt32(PuntuacionScript.valorMaximo)){
            puntuacion.text = "!!Felicidades Nuevo Record!!";
            max.text = "Puntuacion Maxima: " + PuntuacionScript.puntuacionObtenida;

        }
        else{
		    puntuacion.text = "Puntuacion Obtenida: "+PuntuacionScript.puntuacionObtenida;
		    max.text ="Puntuacion Maxima: "+ PuntuacionScript.valorMaximo;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
