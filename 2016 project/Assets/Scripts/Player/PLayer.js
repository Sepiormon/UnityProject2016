#pragma strict

var MovementSpeed : float = 10;
var Speedlimit : float = 10;
var JumpHeight : float = 10;

function Start () {

}

function Update () {
//movement
	if(Input.GetKey("a")){
		GetComponent.<Rigidbody2D>().AddForce(new Vector2(-MovementSpeed, 0));
	}
	if(Input.GetKey("d")){
		GetComponent.<Rigidbody2D>().AddForce(new Vector2(MovementSpeed, 0));
	}
	//Speedlimit
	if(GetComponent.<Rigidbody2D>().velocity.x < -Speedlimit){
		GetComponent.<Rigidbody2D>().velocity.x = -Speedlimit;
	} else if(GetComponent.<Rigidbody2D>().velocity.x > Speedlimit){
		GetComponent.<Rigidbody2D>().velocity.x = Speedlimit;
	}
	//jump
	if(Input.GetKeyDown("space")){
		GetComponent.<Rigidbody2D>().AddForce(new Vector2(0, JumpHeight));
	}
//end movement
}