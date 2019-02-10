using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.

public class Timer : MonoBehaviour {

	public float time = 90.0f;
    public GameObject sonidoObj;
    AudioSource sonido;
    //TextMesh tm;
    public GameObject txt;
    TextMeshProUGUI tm;

    //public static string nivel="";

    void Start () {
        //tm = GetComponent<TextMesh>();
        sonido = sonidoObj.GetComponent<AudioSource>();
        tm = txt.GetComponent<TextMeshProUGUI>();
        StartCoroutine(Contador());
    }
	
	void FixedUpdate () {
		time -= Time.deltaTime;

        //tm.text = "Hola que hace :v";
        tm.text = Mathf.RoundToInt(time).ToString();
		if (tm.text == "0") {
            Application.LoadLevel (BotonPlay.nivel);
		}

	}


    IEnumerator Contador(){
        sonido.Play();
        yield return new WaitForSeconds(1.0f);
        sonido.Play();
        yield return new WaitForSeconds(1.0f);
        sonido.Play();
        yield return new WaitForSeconds(1.0f);
        sonido.Play();
        yield return new WaitForSeconds(1.0f);
        sonido.Play();
        yield return new WaitForSeconds(2.0f);

    }
}
