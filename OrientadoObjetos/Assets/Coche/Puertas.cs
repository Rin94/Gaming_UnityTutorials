using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour {

	public int cantidad;
	public bool cerrojo;

	public Puertas(int cantidad, bool cerrojo){
		this.cantidad=cantidad;
		this.cerrojo=cerrojo;
	}

}
