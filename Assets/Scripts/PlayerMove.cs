using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float maxSpeed = 2f;
	
	void Start () {
		
	}
	
	void Update () {
		
		float xtrans = 0;
		float ytrans = 0;
		
		
		xtrans = Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
		
		ytrans = Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
		
		transform.Translate (-xtrans, 0f, -xtrans);
		transform.Translate (-ytrans, 0f, ytrans);
		
		
	}
}
