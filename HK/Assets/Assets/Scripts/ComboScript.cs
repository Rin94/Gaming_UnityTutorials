using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComboScript : MonoBehaviour {


	public int xCombo = 1;
    //public TextMesh Combo;
    public Text Combo;
    public GameObject comboObj;
    Color colorOriginal;
    AudioSource audioCombo;



	
	// Use this for initialization
	public void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "incrementarCombo");
		NotificationCenter.DefaultCenter().AddObserver(this, "decrementarCombo");
		ActualizarMarcador (true);
        //colorOriginal = Combo.color;
        audioCombo = comboObj.GetComponent<AudioSource>();


	}
	
	public void incrementarCombo(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		xCombo+=puntosAIncrementar;
		ActualizarMarcador();
	}

	public void decrementarCombo(Notification notificacion){
		ActualizarMarcador (true);
	}
	
	public void ActualizarMarcador(){
        Combo.text = "Combo X" + xCombo.ToString();
        //Debug.Log(xCombo.ToString());
        if (xCombo.ToString()=="2"){
            Combo.text = "Combo X" + xCombo.ToString();
            Combo.color = new Color(0.0f, 210.0f / 255.0f, 192.0f / 255.0f);
           // audioCombo.Play();

        }
        else if(xCombo.ToString() == "5"){
            audioCombo.Play();
            Combo.color = new Color(53.0f / 210.0f, 152.0f / 236.0f, 255.0f / 255.0f);
            Combo.text = "Combo X" + xCombo.ToString();
            // Combo.text = "Combo X" + xCombo.ToString();

        }

    }
	public void ActualizarMarcador(bool b){
		Combo.text = " ";
        //Combo.color = colorOriginal;
		xCombo = 1;
		
	}
	
	// Update is called once per frame
	public void Update () {
		
	}


}
