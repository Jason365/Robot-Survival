using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smooth= 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	void  Update (){
		transform.position = Vector3.Lerp (
			transform.position, target.position,
			Time.deltaTime * smooth);
	
	}  	
}
