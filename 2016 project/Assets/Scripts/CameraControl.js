#pragma strict

var Player : GameObject;

function Update () {
//Camera follow player
	gameObject.transform.position.x = Player.transform.position.x;
//End Follow player
}