using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fundidos : MonoBehaviour {

	public Image fundido;
	public string[] escenas;

	// Use this for initialization
	void Start () {
		//Debug.Log ("HOla");
		fundido.CrossFadeAlpha (0, 2, false);
	}

	public void FadeOut(int s){
		Debug.Log ("HOla");
		fundido.CrossFadeAlpha (1, 2, false);
		StartCoroutine (CambioEscena (escenas [s]));
	}

	IEnumerator CambioEscena(string escena){
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene (escena);
	}
	

}
