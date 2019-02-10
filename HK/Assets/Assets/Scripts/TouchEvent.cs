using UnityEngine;
using System.Collections;

public class TouchEvent : MonoBehaviour {

	private bool moveLeft;
	private bool moveRight;
	void Update () {
		if(moveLeft && !moveRight){
			transform.localScale = new Vector3(15,20,1);
		}
		if(moveRight && !moveLeft){
			transform.localScale = new Vector3(-15,20,1);
		}
	}
	public void MoveMeLeft(){
		moveLeft = true;
	}
	public void MoveMeRight(){
		moveRight=true;
	}
	public void StopMeLeft(){
		moveLeft = false;
	}
	public void StopMeRight(){
		moveRight = false;
	}
}
