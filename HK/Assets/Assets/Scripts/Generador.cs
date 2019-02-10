using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Generador : MonoBehaviour {

	public GameObject[] obj;
	public GameObject[] poc;
	public float tiempoMin = 1.25f;
	public float tiempoMax = 2.5f;
	public float tiempoMinP = 10.25f;
	public float tiempoMaxP = 20.5f;
	public bool	 combo=false;
	public static Generador gen;
	public bool posion=false;
    public Text puntuacion;
    public GameObject score;
    public int punt_txt;
	
	// Use this for initialization
	void Start () {

        //score = GameObject.Find("puntuacion_text");
        //puntuacion = score.GetComponent<Text>();
		Generar();
		NotificationCenter.DefaultCenter().AddObserver(this, "generarLibros");
		NotificationCenter.DefaultCenter().AddObserver(this, "generarPosiones");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void PersonajeEmpiezaACorrer(Notification notificacion){
		Generar();
	}

	public void  Posion(){
		Instantiate (obj [Random.Range (0, 1)], transform.position, Quaternion.identity);
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

	}

	void Generar(){
        punt_txt = System.Convert.ToInt32(puntuacion.text);

        if (BotonPlay.nivel == "nivel_retro" || BotonPlay.nivel == "nivel_tiempo")
        {
            generarRetro();
        }
        else
        {
            if (punt_txt < 700)
            {
                if (combo == true)
                {
                    float valor = Random.Range(0, obj.Length);
                    if (valor == 2.0f || valor == 0.0f)
                    {
                        Instantiate(obj[1], transform.position, Quaternion.identity);
                        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                    }
                    else
                    {
                        Instantiate(obj[(int)valor], transform.position, Quaternion.identity);
                        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                    }
                }
                else
                {
                    Instantiate(obj[1], transform.position, Quaternion.identity);
                    Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                }
            }
            else if (punt_txt >= 700 && punt_txt <= 2000)
            {
                if (combo == true)
                {
                    float valor = Random.Range(0, obj.Length);
                    if (valor == 2.0f)
                    {
                        Instantiate(obj[1], transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(obj[(int)valor], transform.position, Quaternion.identity);
                    }
                    Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                }
                else
                {
                    Instantiate(obj[Random.Range(0, obj.Length - 2)], transform.position, Quaternion.identity);
                    Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                }
            }

            else
            {
                if (combo == true)
                {
                    if (BotonPlay.dificultad == true)
                    {
                        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
                        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                    }
                    else
                    {
                        float valor = Random.Range(0, obj.Length);
                        if (valor == 2.0f)
                        {
                            Instantiate(obj[Random.Range(0, 1)], transform.position, Quaternion.identity);
                            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

                        }
                        else
                        {
                            Instantiate(obj[(int)valor], transform.position, Quaternion.identity);
                            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

                        }

                    }
                }
                else
                {

                    if (BotonPlay.dificultad == true)
                    {
                        Instantiate(obj[Random.Range(0, obj.Length - 1)], transform.position, Quaternion.identity);
                        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
                    }
                    else
                    {
                        Instantiate(obj[Random.Range(0, obj.Length - 2)], transform.position, Quaternion.identity);
                        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

                    }
                }

            }


        }

			
	}

	void generarLibros(Notification notification){
		combo = (bool)notification.data;
		//Debug.Log ("Combo:" + combo);
	}

    void generarRetro(){
        if (punt_txt < 500){
                Instantiate(obj[1], transform.position, Quaternion.identity);
                Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

        }
        else{
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));

        }

    }

	void generarPosiones(Notification notification){
		posion = (bool)notification.data;
		//Debug.Log ("Combo:" + combo);
	}



}
