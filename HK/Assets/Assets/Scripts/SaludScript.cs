using UnityEngine;
using System.Collections;

/// <summary>
/// Comportamiento de la salud de los objetos
/// </summary>
public class SaludScript : MonoBehaviour {
	
	/// <summary>
	/// Numero de puntos de salud
	/// </summary>
    public static int ps = 5;
	public int pierde=0;
	public int comboMaker=0;
	public float time = 03.0f;
    public Camera camara;
    public GameObject audioMaloObject;
    public GameObject audioBuenoObject;
    AudioSource audioMalo;
    AudioSource audioBueno;

    bool bandera=false;
	/// <summary>
	/// Es jugador o enemigo?
	/// </summary>
	public bool esEnemigo = true;


     void Start(){
        ps = 5;
        InicializarSonidos();

    }

    void Update () {
        if (ps <= 2)
        {
            CambiarSonido();
        }
        if (ps >= 3)
        {
            CambiarANormalSonido();
        }
    }
	
	void OnTriggerEnter2D(Collider2D collider){
        //Es un disparo?

        DisparoScript disparo = collider.gameObject.GetComponent<DisparoScript>();
		if (disparo != null){
			hacerCombos();
			chido ();
            //ps>=5&&
            if (disparo.danho<0){
                //ps=ps;//are the same
                audioBueno.Play();
                //ps -= disparo.danho;
                if(ps<5){
                    ps = ps + 1;
                }
                ponerVida(true, disparo.danho);

                Destroy(disparo.gameObject);


            }
			else if (disparo.danho==0){
                audioBueno.Play();
                ponerVida ();
                Destroy(disparo.gameObject);
			}
            else{
                Debug.Log(ps);
				ps -= disparo.danho;
				decrementarVida(disparo.danho);
				}
		}
		Destroy (disparo.gameObject);
	}

	public void ponerVida(){
		int puntosGanados=100;
		comboMaker=comboMaker+1;

		NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
	}

    public void ponerVida(bool f,int dano)
    {
        int puntosGanados = 200;
        comboMaker = comboMaker + 1;
        NotificationCenter.DefaultCenter().PostNotification(this, "DecrementarPuntos", dano);
        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
    }

    public void decrementarVida(int dano){
        audioMalo.Play();
        if (ps <= 0){
			// Muerto!
			NotificationCenter.DefaultCenter().PostNotification(this, "DecrementarPuntos",0 );
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
			Destroy(gameObject);
		}
		else{

			NotificationCenter.DefaultCenter().PostNotification(this, "DecrementarPuntos", dano);
			if(dano>0){
				comboMaker=0;
				NotificationCenter.DefaultCenter().PostNotification(this, "decrementarCombo",0 );
			}
		}
	}

	public void hacerCombos(){
		if (comboMaker > 0) {
			NotificationCenter.DefaultCenter().PostNotification(this, "incrementarCombo",1);
		}
	}

	public int getCombo(){
		return comboMaker;
	}

	public void chido(){
        //originalmente eran 10
		if (comboMaker >= 5) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "generarLibros", true);

		} else {
			NotificationCenter.DefaultCenter ().PostNotification (this, "generarLibros", false);

		}
	}

    public void CambiarSonido(){
        AudioSource auS = camara.GetComponent<AudioSource>();
        bandera = true;
        auS.pitch=1.66f;

    }

    public void CambiarANormalSonido()
    {
        AudioSource auS = camara.GetComponent<AudioSource>();
        auS.pitch = 1.0f;
        bandera = false;

    }

    public void InicializarSonidos(){
        audioMalo = audioMaloObject.GetComponent<AudioSource>();
        audioBueno = audioBuenoObject.GetComponent<AudioSource>();

    }

}

