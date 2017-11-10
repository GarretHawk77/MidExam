using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour 
{
	public float speed = 10.0f;

	Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		float vertical = Input.GetAxis ("Vertical");
		Vector3 desiredVelocity = transform.forward * speed * vertical;
		rb.velocity = desiredVelocity;

		float horizontal = Input.GetAxis ("Horizontal");
		transform.Rotate (0f, horizontal, 0f);
	}


}
