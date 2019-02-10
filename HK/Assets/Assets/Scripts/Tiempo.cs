using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tiempo : MonoBehaviour
{



    /// <summary>
    /// Numero de puntos de salud
    /// </summary>
    public static int ps = 5;
    public int pierde = 0;
    public int comboMaker = 0;
    public float time = 03.0f;
    public Camera camara;
    public GameObject audioMaloObject;
    public GameObject audioBuenoObject;
    AudioSource audioMalo;
    AudioSource audioBueno;
    public float time_t = 90.0f;
    public GameObject sonidoObj;
    AudioSource sonido;
    //TextMesh tm;
    public GameObject txt;
    Text tm;
    bool bandera = false;
    /// <summary>
    /// Es jugador o enemigo?
    /// </summary>
    public bool esEnemigo = true;


    void Start()
    {

        InicializarSonidos();
        sonido = sonidoObj.GetComponent<AudioSource>();
        tm = txt.GetComponent<Text>();

    }

    void FixedUpdate()
    {
        time_t -= Time.deltaTime;
        tm.text = Mathf.RoundToInt(time_t).ToString();
        if (time_t <= 20.0f)
        {
            CambiarSonido();
        }
        if (time_t >= 20.1f)
        {
            CambiarANormalSonido();
        }

        if (tm.text == "0")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
            Application.LoadLevel("PantallaScene");
        }

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        DisparoScript disparo = collider.gameObject.GetComponent<DisparoScript>();
        if (disparo != null)
        {
            hacerCombos();
            chido();
            if (disparo.danho < 0)
            {
                audioBueno.Play();
                time_t = time_t + 10;
                ActualizarMarcador();
                ponerVida(true, disparo.danho);
                Destroy(disparo.gameObject);

            }
            else if (disparo.danho == 0)
            {
                audioBueno.Play();
                ponerVida();
                time_t = time_t + 5;
                ActualizarMarcador();
                Destroy(disparo.gameObject);
            }
            else if (disparo.danho == 1)
            {
                time_t = time_t - 10;
                decrementarVida(disparo.danho);
                Destroy(disparo.gameObject);
            }
            else if (disparo.danho == 2)
            {
                time_t = time_t - 20;
                decrementarVida(disparo.danho);
                Destroy(disparo.gameObject);
            }
        }

    }

    public void ponerVida()
    {
        int puntosGanados = 100;
        comboMaker = comboMaker + 1;
        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
    }

    public void ponerVida(bool f, int dano)
    {
        int puntosGanados = 200;
        comboMaker = comboMaker + 1;
        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
    }

    public void decrementarVida(int dano)
    {
        ActualizarMarcador();
        audioMalo.Play();
        if (time_t <= 0)
        {
            Application.LoadLevel("PantallaScene");
            NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
            Destroy(gameObject);
        }
        else
        {

            if (dano > 0)
            {
                comboMaker = 0;
                NotificationCenter.DefaultCenter().PostNotification(this, "decrementarCombo", 0);
            }
        }
    }

    public void hacerCombos()
    {
        if (comboMaker > 0)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "incrementarCombo", 1);
        }
    }

    public int getCombo()
    {
        return comboMaker;
    }

    public void chido()
    {
        if (comboMaker >= 5)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "generarLibros", true);

        }
        else
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "generarLibros", false);

        }
    }

    public void ActualizarMarcador()
    {
        tm.text = time_t.ToString();
    }

    public void CambiarSonido()
    {
        AudioSource auS = camara.GetComponent<AudioSource>();
        bandera = true;
        auS.pitch = 1.66f;

    }

    public void CambiarANormalSonido()
    {
        AudioSource auS = camara.GetComponent<AudioSource>();
        auS.pitch = 1.0f;
        bandera = false;

    }

    public void InicializarSonidos()
    {
        audioMalo = audioMaloObject.GetComponent<AudioSource>();
        audioBueno = audioBuenoObject.GetComponent<AudioSource>();

    }

}


