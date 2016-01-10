using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float MovementSpeed = 10;
	float SpeedLimit = 10;
	float JumpHeight = 400;
	bool OnGround = false;

	void Start () 
	{
	
	}
	
	
	void Update ()
	{
	//movement via acceleration
		if(Input.GetKey("a")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-MovementSpeed, 0));
		}
		if(Input.GetKey("d")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(MovementSpeed, 0));
		}
		//Speed limit via velocity
        var rb = GetComponent<Rigidbody2D>();

		if(GetComponent<Rigidbody2D>().velocity.x < -SpeedLimit)
		{
			rb.velocity = new Vector2(-SpeedLimit,rb.velocity.y);
		}
		if(GetComponent<Rigidbody2D>().velocity.x > SpeedLimit)
		{
            rb.velocity = new Vector2(SpeedLimit, rb.velocity.y);
		}
		//jump (via massive upwards acceleration)
		if(Input.GetKeyDown("space") && OnGround)
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpHeight));
		}
	//end movement
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.gameObject.tag == "Ground")
		{
			OnGround = true; //Landing on ground
		}
	}

	void OnCollisionExit2D (Collision2D other)
	{
		if(other.gameObject.tag == "Ground")
		{
			OnGround = false; //Off ground
		}
	}
}
