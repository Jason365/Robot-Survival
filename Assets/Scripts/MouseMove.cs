﻿using UnityEngine;
using System.Collections;

public class MouseMove : MonoBehaviour {
	public Ray cameraRay;                // The ray that is cast from the camera to the mouse position
	public RaycastHit cameraRayHit;    // The object that the ray hits
	
	void Update () 
	{
		// Cast a ray from the camera to the mouse cursor
		cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		// If the ray strikes an object...
		if (Physics.Raycast(cameraRay, out cameraRayHit)) 
		{
			// ...and if that object is the ground...
			if(cameraRayHit.transform.tag=="Ground")
			{
				// ...make the cube rotate (only on the Y axis) to face the ray hit's position 
				Vector3 targetPosition = new Vector3(cameraRayHit.point.x, transform.position.y, cameraRayHit.point.z);
				transform.LookAt(targetPosition);
			}
		}
	}
}