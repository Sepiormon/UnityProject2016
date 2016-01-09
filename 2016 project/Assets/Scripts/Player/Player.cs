using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    float MovementSpeed = 10;
    float SpeedLimit = 10;
    float JumpHeight = 400;
    bool OnGround = false;

    void Start()
    {

    }


    void Update()
    {
		var rb = GetComponent<Rigidbody2D>();
        //movement via acceleration
        if (Input.GetKey("a")) {
            rb.AddForce(new Vector2(-MovementSpeed, 0));
        }
        if (Input.GetKey("d")) {
            rb.AddForce(new Vector2(MovementSpeed, 0));
        }
        //Speed limit via velocity
        
        if (rb.velocity.x < -SpeedLimit) {
            rb.velocity = new Vector2(-SpeedLimit, rb.velocity.y);
        } else if (rb.velocity.x > SpeedLimit) {
            rb.velocity = new Vector2(SpeedLimit, rb.velocity.y);
        }
        //jump (via massive upwards acceleration)
        if (Input.GetKeyDown("space") && OnGround) {
            rb.AddForce(new Vector2(0, JumpHeight));
        }
        //end movement
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            OnGround = true; //landing on ground.
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            OnGround = false; //no longer touching ground.
        }
    }

}
