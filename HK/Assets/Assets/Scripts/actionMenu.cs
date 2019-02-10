using UnityEngine;
using System.Collections;

public class actionMenu : MonoBehaviour
{
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Input.GetMouseButtonDown (0)) {
			if(Physics.Raycast(ray, out hit)) {
				string name = hit.collider.transform.parent.name;
				if(name.Contains("New Game")){
					Application.LoadLevel("EscenaPreparacion");
				} else if(name.Contains("Options")) {
					Application.LoadLevel("opciones");
				} else if(name.Contains ("Quit")) {
					Application.Quit ();
				}
			}
		}
	}
}

