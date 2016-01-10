using UnityEngine;
using System.Collections;

public class Manipulation : MonoBehaviour {

	float distance = 10;
	Material DefMat;
	bool triggered = false;
	GameObject Lite;
	bool lighton = false;
	public GameObject Player;

	void Start()
	{	
		Debug.Log("why2");
		DefMat = GetComponent<Renderer>().material;
		Lite = new GameObject("Manipulatior Light");
		Light liteComp = Lite.AddComponent<Light>();
		liteComp.color = Color.blue;
		liteComp.intensity = 15;
	}

	void Update()
	{
		if(lighton)
		{
			Lite.SetActive(true);
		}
		else 
		{
			Lite.SetActive(false);
		}
	}

	void OnMouseOver()
	{
		float pdistance = Vector3.Distance(Player.transform.position, gameObject.transform.position);
		var rb = GetComponent<Rigidbody2D>();
		if(Input.GetMouseButton(0) && !triggered && pdistance < 10)
		{
			Lite.transform.position = gameObject.transform.position;
			lighton = true;
			rb.velocity = Vector2.zero;
			rb.gravityScale = 0;
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = distance;
			transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
		} 
		else 
		{
			rb.gravityScale = 1;
			lighton = false;
		}
	}

	void OnMouseExit()
	{
		if(lighton)
		{
			GetComponent<Rigidbody2D>().gravityScale = 1;
			lighton = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("yolo");
		triggered = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		triggered = false;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		triggered = true;
	}

}	





