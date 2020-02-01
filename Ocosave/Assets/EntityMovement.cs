using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour {

	[SerializeField] private float minVelocity = 1;
	[SerializeField] private float maxVelocity = 10;
	private Rigidbody2D rb;
	private Vector2 velocity;

	void Awake(){
		rb = this.gameObject.GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		velocity = new Vector2 (Random.Range (-maxVelocity, -minVelocity), 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		rb.MovePosition (rb.position + velocity * Time.deltaTime);
	}
}
