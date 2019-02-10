using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerarquias : MonoBehaviour {

	public Transform miTransform = null;

	// Use this for initialization
	void Start () {

		miTransform = GetComponent<Transform> ();
		for ( int i=0; i< miTransform.childCount; i++) {

			Transform hijo = miTransform.GetChild(i);
			Debug.Log (hijo.gameObject.name);

			
			

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
