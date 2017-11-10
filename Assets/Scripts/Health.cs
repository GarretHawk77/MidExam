using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour 
{
	public float MaxHealth = 100.0f;
	public float startingHealth = 50.0f;
	public Slider healthSlider; 
	float currentHealth; 

	void Start ()
	{
		currentHealth = startingHealth;
		healthSlider.value = currentHealth;
	}

	public void Heal (float amountToHeal)
	{
		currentHealth += amountToHeal;
		if (currentHealth > MaxHealth) {
			currentHealth = MaxHealth; 

		}

		healthSlider.value = currentHealth;
	}

	public void Damage (float amountToDamage)
	{
		currentHealth -= amountToDamage;
		if (currentHealth < 0f) {
			currentHealth = 0f;

		}

		healthSlider.value = currentHealth;
	}
}
