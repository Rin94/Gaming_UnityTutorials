using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingElephant : MonoBehaviour {

	public float walking;
	public Animator anim;
	public float velocidad;
	public int rotar;
	public int life=3;
	public HealthBar hb;
	public AudioSource sonidoElefante;
	public AudioSource sonidoMuerte;

	// Use this for initialization
	void Start () {
		hb = GameObject.FindGameObjectWithTag ("UI").GetComponent<HealthBar>();
		anim = GetComponent<Animator> ();
		velocidad = 5;
		rotar = 0;
		sonidoElefante = GetComponent<AudioSource> ();
		sonidoMuerte = GameObject.Find("SonidoMuerte").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		Mover();
		BajarVida ();
		AnimacionMorir ();


		
	}
	void AnimacionMorir(){
		
		anim.SetInteger ("LIFE", life);

		if (life <= 0) {
			//Debug.Log ("HolaEstoyAqui");

			StartCoroutine (Morir ());
		}
		
	}

	IEnumerator Morir(){
		
		yield return new WaitForSeconds (10.0f);
		Destroy(this.gameObject);
	}

	void BajarVida(){
		if(Input.GetKeyDown(KeyCode.X)){
			life = life - 1;
			hb.AddHealth (-1.0f);
			sonidoElefante.Play ();
			if (life <= 0) {
				sonidoMuerte.Play();
			}


		}
	}

	void Mover(){
		//KeyCode.LeftArrow
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//Rotar (rotar,-90);
			AnimarMovimiento (0.2f);
			this.transform.Translate (Vector3.left * velocidad * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			//Rotar (rotar,90);
			AnimarMovimiento (0.2f);
			this.transform.Translate (Vector3.right * velocidad * Time.deltaTime);
			
		}

		else if (Input.GetKey (KeyCode.UpArrow)) {
			//Rotar (rotar,0);
			AnimarMovimiento (0.2f);
			this.transform.Translate (0,0,1 * velocidad * Time.deltaTime);

		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			
			AnimarMovimiento (0.2f);
			this.transform.Translate (0,0,-1 * velocidad * Time.deltaTime);
			//Rotar (rotar,180);

		}
		else{
			
			AnimarMovimiento (0.0f);
			rotar = 0;

		}
	}


	void Rotar(int i,int rotacion){
		if (i == 0) {
			this.transform.rotation=Quaternion.Euler (0,rotacion,0);
			rotar = 1;
			
		}	
	}

	void AnimarMovimiento(float movimiento){
		anim.SetFloat ("WALKING", movimiento);
	}


	
}
