#pragma strict

var MovementSpeed : float = 5;
var Speedlimit : float = 20;
function Start () {

}

function Update () {
//movement
	if(Input.GetKey("a")){
		rigidbody2D.AddForce(new Vector2(-MovementSpeed, 0));
	}
	if(Input.GetKey("d")){
		rigidbody2D.AddForce(new Vector2(MovementSpeed, 0));
	}
//Speedlimit
	if(rigidbody2D.GetVe)
//end movement
}