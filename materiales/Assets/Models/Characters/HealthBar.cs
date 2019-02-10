using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	private float health;
	private float maxHealth;
	private float minHealth;
	public GameObject hellephant;
	public WalkingElephant el;
	public Image healthImage;



	// Use this for initialization
	void Start () {
		minHealth = 0;
		hellephant = GameObject.FindWithTag ("Player");
		el = hellephant.GetComponent<WalkingElephant> ();
		maxHealth = (float)el.life;
		health = maxHealth;


		
	}

	public void AddHealth(float amount){
		
		health = health+ amount;
		Debug.Log (health);
		if (health > maxHealth) {
			health = maxHealth;
		} else if (health < 0) {
			health = minHealth;
		}
		UpdateHealhUI ();
	}

	public void UpdateHealhUI(){
		healthImage.fillAmount = (1 / maxHealth) * (health);
	}
		
}
