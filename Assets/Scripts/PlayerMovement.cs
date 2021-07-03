using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwarForce = 2000f;
	public float sideForce = 1000f;

	void Start () {
		
	}
	
	void FixedUpdate () {
		rb.AddForce (0, 0, forwarForce * Time.deltaTime);
		if (Input.GetKey("d")) {
			rb.AddForce (sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) {
			rb.AddForce (-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y <= -1f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
