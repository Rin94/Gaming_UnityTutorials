using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionRotacion : MonoBehaviour {

	public float velocidad;
	public float velocidadRotSobreSi;
	public float velocidadSobreWorld;
	private Transform miTransform;
	private Transform []ninos;


	// Use this for initialization
	void Start () {
		miTransform = GetComponent<Transform> ();
		ninos = GetComponentsInChildren<Transform> ();

		
	}
	
	// Update is called once per frame
	void Update () {

		miTransform.Translate (Vector3.forward * velocidadSobreWorld * Time.deltaTime);//y

		//miTransform.Translate (Vector3.left* velocidad * Time.deltaTime);//x
		//miTransform.Translate (Vector3.up * velocidad * Time.deltaTime); //arriba//z
		//miTransform.Translate (Vector3.right * velocidad * Time.deltaTime);//x
		miTransform.Rotate(Vector3.up*velocidadRotSobreSi*Time.deltaTime);
		//miTransform.Rotate (Vector3.forward * velocidadadRotSobreWorld * Time.deltaTime);
		foreach (Transform n in ninos) {
			if (n.gameObject.name=="Luna"){
				velocidad=100;
				n.Rotate(Vector3.down*velocidad*Time.deltaTime,Space.Self);

			}
			else{
				velocidad = 50;
				n.Rotate(Vector3.down*velocidad*Time.deltaTime,Space.Self);

				}
		}
		//nino.Translate(Vector3.forward*velocidad*Time.deltaTime,Space.Self);

		
	}
}
