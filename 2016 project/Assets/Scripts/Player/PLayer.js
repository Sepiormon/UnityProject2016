#pragma strict

var MovementSpeed : float = 10;
var Speedlimit : float = 10;
var JumpHeight : float = 400;
var OnGround : boolean = false;

function Start () {

}

function Update () {
//movement via acceleration
	if(Input.GetKey("a")){ //left
		GetComponent.<Rigidbody2D>().AddForce(new Vector2(-MovementSpeed, 0));
	}
	if(Input.GetKey("d")){ //right
		GetComponent.<Rigidbody2D>().AddForce(new Vector2(MovementSpeed, 0));
	}
	//Speedlimit via velocity
	if(GetComponent.<Rigidbody2D>().velocity.x < -Speedlimit){
		GetComponent.<Rigidbody2D>().velocity.x = -Speedlimit;
	} else if(GetComponent.<Rigidbody2D>().velocity.x > Speedlimit){
		GetComponent.<Rigidbody2D>().velocity.x = Speedlimit;
	}
	//jump (via massive upwards acceleration)
	if(Input.GetKeyDown("space") && OnGround){
		GetComponent.<Rigidbody2D>().AddForce(new Vector2(0, JumpHeight));
	}
//end movement
//debugs
}

function OnCollisionEnter2D (other: Collision2D){
	if(other.gameObject.tag == "Ground"){
		OnGround = true; //if on ground, make true
	}
}

function OnCollisionExit2D (other: Collision2D){
	if(other.gameObject.tag == "Ground"){
		OnGround = false; //if leaving ground, make false
	}
}

function OnCollisionStay2D (other : Collision2D){
	if(other.gameObject.tag == "Ground"){
		OnGround = true; //Still on the ground.
	}
}