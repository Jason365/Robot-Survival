using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.W)) //up
		{
			transform.Translate ((new Vector3(-1,1,0)) * speed * Time.deltaTime);
			//transform.Rotate (Vector3 ;
		}
		if (Input.GetKey (KeyCode.S)) //down
		{
			transform.Translate ((new Vector3(1,-1,0)) * speed * Time.deltaTime);
		} 
		if (Input.GetKey (KeyCode.A))//left
		{
			transform.Translate ((new Vector3(1,1,0)) * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D))//right
		{
			transform.Translate ((new Vector3(-1,-1,0)) * speed * Time.deltaTime);
		}
	}
}