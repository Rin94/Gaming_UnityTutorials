using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Empezar : MonoBehaviour {

	void Start()
	{
		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		print(Time.time);
		yield return new WaitForSeconds(15);
		SceneManager.LoadScene ("piano");

	}
	
	// Update is called once per frame
	void Update () {

	}




		
}
