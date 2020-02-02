using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatSwingy : MonoBehaviour {

	private Rigidbody2D rb;
	[SerializeField] private float maxForwardAngle = -10.0f;
	[SerializeField] private float maxBackwardAngle = 12.0f;
	[SerializeField] private float rotationAmount = 0.0f;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		rb.rotation += rotationAmount;

		if (rb.rotation > maxBackwardAngle) {
			rotationAmount *= -1.0f;
		}

		else if (rb.rotation < maxForwardAngle) {
			rotationAmount *= -1.0f;
		}
	}
}
