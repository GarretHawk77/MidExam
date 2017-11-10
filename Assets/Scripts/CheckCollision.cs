using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour 
{
	void OnCollisionEnter (Collision other)
	{
		Debug.Log ("Collision Detected");
	}

	void OnCollisionExit (Collision other)
	{
		Debug.Log ("Collision Exited");
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Trigger Entered");
	}

	void OnTriggerExit (Collider other)
	{
		Debug.Log ("Trigger Exited");
	}
}
