using UnityEngine;
using System.Collections;

public class PlayerMovement1 : MonoBehaviour {

	float maxSpeed = 4f;
	
	void Start () {
	
	}

	void Update () {

		Vector3 pos = transform.position;

		pos.x += -Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

		pos.y += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;


	}
}
