using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benzema : MonoBehaviour {

	public float amountToDamage = 20.0f;

	void OnTriggerEnter (Collider other)
	{
		Health damagerHealth = (Health) other.GetComponent<Health> ();
		if (damagerHealth != null) 
		{
			damagerHealth.Damage (amountToDamage); 
			Destroy (gameObject);
		}

	}
}
