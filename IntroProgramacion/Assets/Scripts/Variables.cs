using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	// Use this for initialization

	string saludo= "Hola mundo";
	int numeroEntero= 0;
	float numeroDecimal= 10.5f;
	bool boleano= true;
	double numeroDecimal2=15.5;

	public GameObject cubo;
	public Transform trans;
	public MeshFilter meshFilter;
	public BoxCollider boxCollider;
	public MeshRenderer meshRenderer;



	void Start () {
		Debug.Log(saludo+" "+numeroEntero+" "+numeroDecimal+" "+numeroDecimal2+" "+boleano);
		cubo.SetActive (true);


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
