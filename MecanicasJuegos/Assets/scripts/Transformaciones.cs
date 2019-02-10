using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformaciones : MonoBehaviour {

	private Transform miTransform= null;
	private Vector3 pos;
	private GameObject cuboAzul = null;
	private Transform transformAzul= null;

	// Use this for initialization
	void Start () {
		cuboAzul = GameObject.Find ("CuboAzul");
		transformAzul = cuboAzul.GetComponent<Transform> ();
		transformAzul.position = new Vector3 (-3, transformAzul.position.y, -3);
		miTransform = GetComponent<Transform> ();
		pos=miTransform.position=new Vector3(2,2,2);
		
	}
	
	// Update is called once per frame
	void Update () {
		pos = miTransform.position = new Vector3 (miTransform.position.x + 0.001f, miTransform.position.y + 0.001f, miTransform.position.z + 0.001f);
		
		
	}
}
