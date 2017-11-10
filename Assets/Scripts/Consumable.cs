using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour 
{
	public float amountToHeal = 10.0f;

	void OnTriggerEnter (Collider other)
	{
		Health consumerHealth = (Health) other.GetComponent<Health> ();
		if (consumerHealth != null) 
		{
			consumerHealth.Heal (amountToHeal); 
			Destroy (gameObject);
		}

	}
		
}
