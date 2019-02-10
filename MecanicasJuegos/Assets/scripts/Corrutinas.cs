using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour {

	public Stack <Cubo> cubos = new Stack<Cubo>();

	// Use this for initialization
	void Start () {
		Cubo []arrayCubo = GameObject.FindObjectsOfType<Cubo>();
		foreach (Cubo c in arrayCubo) {
			cubos.Push (c);
			Debug.Log (c.name);
		}
		StartCoroutine (apagarCubos ());

		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}

	void apagar(){
		if (cubos.Count > 0) {
			cubos.Pop().gameObject.SetActive (false);

		}
		
	}

	IEnumerator apagarCubos(){
		yield return new WaitForSeconds(3.0f);
		apagar();

		yield return new WaitForSeconds (3.0f);
		apagar ();

		yield return new WaitForSeconds (3.0f);
		apagar ();




	}
}
