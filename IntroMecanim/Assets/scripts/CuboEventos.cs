using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEventos : MonoBehaviour {

	Transform cubo;
	Vector3 originalScale;

	public void Start(){
		cubo=GameObject.Find ("Cube").transform;
		originalScale = cubo.localScale;

	}

	public void meHagoGrande(){
		
		cubo.localScale = new Vector3 (3, 3, 3);

		Debug.Log ("Hola Entre");
	}

	public void meHagoPeque(){
		cubo.localScale = originalScale;
	}


}
