using UnityEngine;
using System.Collections;

public class accionesMenu : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Input.GetMouseButtonDown (0)) {
			if(Physics.Raycast(ray, out hit)) {
				string name = hit.collider.transform.parent.name;
				if(name.Contains("jugar")){
					Application.LoadLevel("Nivel1");
				} else if(name.Contains("opciones")) {
					Application.LoadLevel("opciones");
				} else if(name.Contains ("salir")) {
					Application.Quit ();
				}
			}
		}
	}
}
