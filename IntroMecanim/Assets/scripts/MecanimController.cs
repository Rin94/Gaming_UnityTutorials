using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanimController : MonoBehaviour {

	Animator animController;
	int score=0;

	// Use this for initialization
	void Start () {
		animController = GetComponent<Animator> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		avanzar ();
		Salto ();
		Score ();
		AumentarScore ();
		Viento ();

		
		
	}

	void avanzar(){
		if(Input.GetButtonDown("Fire1"))
			animController.SetBool ("avanzar", true);
		if (Input.GetButtonDown ("Fire2"))
			animController.SetBool ("avanzar", false);
		

	}
	void Salto(){
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.A))
			animController.SetTrigger("salto");
		
	}
	//escala
	void Score(){

		animController.SetInteger ("score", score);
		
			
		
	}
	void AumentarScore(){
		if(Input.GetKeyDown(KeyCode.B)){
			score++;
		}

		if(Input.GetKeyDown(KeyCode.C)){
			score--;
		}

		
	}

	void Viento(){
		if(Input.GetKeyDown(KeyCode.D))
			animController.SetFloat("viento",0.5f);
		if (Input.GetKeyDown (KeyCode.F))
			animController.SetFloat ("viento", 0.0f);
		
	}


}
