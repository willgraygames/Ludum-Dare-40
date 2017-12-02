using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Asteroid : MonoBehaviour 
{

	private float speed;
	private Rigidbody2D myBody;

	void Awake()
	{
		myBody = GetComponent<Rigidbody2D> ();
	}
	void Update () 
	{
		myBody.velocity = new Vector2 (1f, 1f);
		transform.position= new Vector2(Random.Range(-10f,10f),Random.Range(-10f,10f));
	}

	//FIX THE SPEED OF THE ASTEROID ASAP
}
