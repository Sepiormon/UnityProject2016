using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

	public GameObject hand;

	void Update () 
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 0;

		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

		if(Input.GetMouseButton(0)){
			hand.GetComponent<Renderer>().material.color = Color.blue;
		} else {
			hand.GetComponent<Renderer>().material.color = Color.grey;
		}
	}
}
