using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float MovementSpeed = 10;
	float SpeedLimit = 10;
	float JumpHeight = 400;

	void Start () {
	
	}
	
	
	void Update () {
	//movement via acceleration
		if(Input.GetKey("a")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-MovementSpeed, 0));
		}
		if(Input.GetKey("d")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(MovementSpeed, 0));
		}
		//Speed limit via velocity
		if(GetComponent<Rigidbody2D>().velocity.x < -SpeedLimit){
			GetComponent<Rigidbody2D>().velocity.x = -SpeedLimit;
		} else if(GetComponent<Rigidbody2D>().velocity.x > SpeedLimit){
			GetComponent<Rigidbody2D>().velocity.x = SpeedLimit;
		}
		//jump (via massive upwards acceleration)
		if(Input.GetKeyDown("space")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpHeight));
		}
	//end movement
	}
}
