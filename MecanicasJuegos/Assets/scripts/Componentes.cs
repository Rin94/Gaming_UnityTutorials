using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes : MonoBehaviour {

	public Transform miTransform;
	public BoxCollider miCollider;
	public MeshRenderer m;


	// Use this for initialization
	void Start () {

		//Debug.Log (gameObject.transform.position.x);

		//Debug.Log ("x: "+miTransform.position.x+", y: "+miTransform.position.y+", z: "+miTransform.position.z);

		miCollider = GetComponent<BoxCollider> ();
		m = GetComponent<MeshRenderer> ();

		m.material.color=Color.red;
		miCollider.enabled = false;
		miCollider.isTrigger = true;


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
