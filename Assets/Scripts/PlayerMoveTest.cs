using UnityEngine;
using System.Collections;

public class PlayerMoveTest : MonoBehaviour {
	
	public float movementSpeed = 2f;
	
	void Start () {
		
	}
	
	void Update () {
		
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		transform.rotation = Quaternion.LookRotation(movement);
		
		
		transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);
			
	}
}
