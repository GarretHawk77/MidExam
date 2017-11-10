using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour 
{
	public GameObject lightObject;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) { 
			Debug.Log ("Player Entered");
			lightObject.SetActive (true);
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) { 
			Debug.Log ("Player Exited");
			lightObject.SetActive (false);
		}
	}
}
