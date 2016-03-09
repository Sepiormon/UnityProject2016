using UnityEngine;
using System.Collections;

public class EnemyGeneric : MonoBehaviour {

	public bool GoingRight = false;
	public float WalkSpeed = 10;
	public bool Active = true;
	public int Dead = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var rb = GetComponent<Rigidbody2D>();
		var vel = gameObject.transform.position.x;

		switch(Active){
//			case Dead:
				
//			break;


			default:
			if(GoingRight){
				vel = WalkSpeed;
			} else { 
				vel = -WalkSpeed;
			}
			break;
		}
	}
}
