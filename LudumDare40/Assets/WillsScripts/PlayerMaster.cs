using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed;
	public int laserDamage;

	public GameObject cameraReference;
	public GameObject laserHousing;

	Rigidbody2D rb2d;

	LineRenderer myLine;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		myLine = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		HandleLaser ();
	}

	void FixedUpdate () {
		HandleMovement ();

	}

	void HandleMovement () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		float rotHorizontal = Input.GetAxis ("RightH");
		float rotVertical = Input.GetAxis ("RightV");
		Vector2 movement = new Vector2 (horizontal, vertical);
		Vector2 rotationality = new Vector3 (rotHorizontal, rotVertical);
		//NEED ROTATION SHIT FUCKERS
		rb2d.AddForce (movement * moveSpeed);
		rb2d.velocity = Vector2.ClampMagnitude (rb2d.velocity, maxSpeed);
	}

	void HandleLaser () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.right);
		myLine.enabled = true;
		myLine.SetPosition (0, transform.position);
		if (hit.collider != null) {
			myLine.SetPosition (1, new Vector2(transform.position.x, transform.position.y + hit.distance));
		} else {
			myLine.SetPosition(1, new Vector2 (transform.position.x, 500));
		}

	}
}
