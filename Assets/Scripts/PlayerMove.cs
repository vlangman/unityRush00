using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private float isMoving;
	public float moveSpeed = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		 Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
		 //Get the angle between the points
		 float angle = AngleBetweenTwoPoints(transform.position, mouseOnScreen) - 90f;
		 transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
		 Debug.DrawLine(transform.position, mouseOnScreen);


		if (Input.GetKey("a")){
			transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
		}
		if (Input.GetKey("d")){
			transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
		}
		if (Input.GetKey("s")){
			transform.position = new Vector3(transform.position.x , transform.position.y - moveSpeed * Time.deltaTime, transform.position.z );
		}
		if (Input.GetKey("w")){
			transform.position = new Vector3(transform.position.x , transform.position.y + moveSpeed * Time.deltaTime, transform.position.z );
		}
	}
	

	float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
		 return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
