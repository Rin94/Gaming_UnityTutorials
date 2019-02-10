using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFX : MonoBehaviour {

	public AudioClip[] fxs;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		
	}

	public void cocheSonidoChoque(){
		audio.clip = fxs [0];
		audio.Play ();

	}

	public void fxMusic(){
		audio.clip = fxs [1];
		audio.Play ();

	}
}
