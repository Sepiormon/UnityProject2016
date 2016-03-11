using UnityEngine;
using System.Collections;

public class EnemyGeneric : MonoBehaviour {

	public bool GoingRight = false;
	public bool Active = true;
	public bool Dead = false;
	public float WalkSpeed = 10;
	public float SpeedLimit = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		var rb = GetComponent<Rigidbody2D>();
		var Pos = gameObject.transform.position.x;
		var velX = rb.velocity.x;
		/*
		Debug.Log(velX);
		if(rb.velocity.x > SpeedLimit){
			velX = SpeedLimit;
		} else if(rb.velocity.x < -SpeedLimit){
			velX = -SpeedLimit;
		}


		if(Dead){

		} else if(Active){
			if(GoingRight){
				GetComponent<Rigidbody2D>().AddForce(new Vector2(WalkSpeed, 0));
			} else {
				GetComponent<Rigidbody2D>().AddForce(new Vector2(-WalkSpeed, 0));
			}
		}
	*/
		if(Dead){

		} else if(Active){
			if(GoingRight){
				Pos = Pos + WalkSpeed;
			} else {
				
			}
		}
	}
}
