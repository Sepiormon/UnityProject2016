using UnityEngine;
using System.Collections;

public class Manipulation : MonoBehaviour {

	float distance = 10;
	Material DefMat;

	void Start()
	{
		DefMat = GetComponent<Renderer>().material;
	}

	void OnMouseOver()
	{
		var mat = GetComponent<Renderer>().material;
		var rb = GetComponent<Rigidbody2D>();
		if(Input.GetMouseButton(0)){
			mat.color = Color.blue;
			rb.velocity = Vector2.zero;
			rb.gravityScale = 0;
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = distance;
			transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
		} else {
			mat = DefMat;
			rb.gravityScale = 1;
		}
	}

	void OnMouseExit()
	{
		var mat = GetComponent<Renderer>().material;
		mat = DefMat;
		GetComponent<Rigidbody2D>().gravityScale = 1;
	}
}	





